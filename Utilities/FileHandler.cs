using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class FileHandler
    {
        //File names used for storing data
        private string _usersFile = @"users.txt";
        private string _lockedFile = @"locked.txt";
        private char _separator = '|';
        private int _maxAttempts = 3;

        //creates files if they don't exist
        public FileHandler()
        {
            if (!File.Exists(_usersFile)) File.Create(_usersFile).Dispose();
            if (!File.Exists(_lockedFile)) File.Create(_lockedFile).Dispose();
        }

        //Read all users from file into a Dictionary
        //Dictionary works like a table: username(key) => password(value)
        private Dictionary<string, string> ReadUsers()
        {
            var users = new Dictionary<string, string>();

            foreach (string line in File.ReadAllLines(_usersFile))
            {
                string[] parts = line.Split(_separator);
                if (parts.Length == 2)
                    users[parts[0].Trim()] = parts[1].Trim();
            }
            return users;
        }

        //Checks if an account is locked
        public bool IsLocked(string username)
        {
            // Reads the locked.txt and check if username is in there
            foreach (string line in File.ReadAllLines(_lockedFile))
                if (line.Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                    return true;
            return false;
        }

        //Saves a new user to users.txt 
        //Returns false if username already exists
        public bool SaveUser(string username, string password)
        {
            if (ReadUsers().ContainsKey(username)) return false;

            //AppendText adds to the end without deleting existing lines
            using (StreamWriter sw = File.AppendText(_usersFile))
                sw.WriteLine(username + _separator + password);

            return true;
        }

        //Validates login credentials
        //Returns: "locked", "success", or "failed"
        public string ValidateLogin(string username, string password)
        {
            if (IsLocked(username)) return "locked";

            var users = ReadUsers();

            //Checks if username exists and password matches
            if (users.ContainsKey(username) && users[username] == password)
            {
                //Resets failed attempts on a successful login
                string attemptFile = "attempts_" + username + ".txt";
                if (File.Exists(attemptFile)) File.Delete(attemptFile);
                return "success";
            }

            //Wrong credentials - tracks failed attempt
            string attFile = "attempts_" + username + ".txt";
            int attempts = File.Exists(attFile) ? int.Parse(File.ReadAllText(attFile)) : 0;
            attempts++;
            File.WriteAllText(attFile, attempts.ToString());

            //Lock account if max attempts reached
            if (attempts >= _maxAttempts)
            {
                File.AppendAllText(_lockedFile, username + Environment.NewLine);
                return "locked";
            }
            //Calculate how many attempts they have left and return it
            int attemptsLeft = _maxAttempts - attempts;
            return attemptsLeft.ToString();  // Returns "2", "1" etc.
        }

        //Unlock an account (admin use)
        public void UnlockAccount(string username)
        {
            //Read all locked accounts, remove this user, rewrite the file
            var lines = new List<string>(File.ReadAllLines(_lockedFile));
            lines.RemoveAll(l => l.Trim().Equals(username, StringComparison.OrdinalIgnoreCase));
            File.WriteAllLines(_lockedFile, lines);

            //Also clear their attempt counter
            string attFile = "attempts_" + username + ".txt";
            if (File.Exists(attFile)) File.Delete(attFile);
        }
    }
}
