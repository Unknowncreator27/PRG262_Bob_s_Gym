using PRG262_Bob_s_Gym.DataAccess;
using PRG262_Bob_s_Gym.Exceptions;
using PRG262_Bob_s_Gym.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static PRG262_Bob_s_Gym.Exceptions.CustomExceptions;

namespace Utilities
{
    public class FileHandler
    {
        private readonly string _usersFile = @"users.txt";
        private readonly string _lockedFile = @"locked.txt";
        private readonly char _separator = '|';
        private readonly int _maxAttempts = 3;

        public FileHandler()
        {
            EnsureFilesExist();
            CreateDefaultAdminIfNotExists();
        }

        public static void SaveAllUsers(List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (var user in users)
            {
                lines.Add($"{user.Username}|{user.Password}|{user.FailedAttempts}|{user.IsLocked}");
            }

            File.WriteAllLines(@"users.txt", lines);
        }

        private void EnsureFilesExist()
        {
            if (!File.Exists(_usersFile)) File.Create(_usersFile).Dispose();
            if (!File.Exists(_lockedFile)) File.Create(_lockedFile).Dispose();
        }

        public static List<User> GetAllUsers(string _usersFile)
        {


            string[] lines = File.ReadAllLines(_usersFile);
            List<User> users = new List<User>();
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('|');
                if (parts.Length >= 4)
                {
                    users.Add(new User
                    {
                        Username = parts[0].Trim(),
                        Password = parts[1].Trim(),
                        FailedAttempts = int.Parse(parts[2]),
                        IsLocked = bool.Parse(parts[3])
                    });
                }
            }
            return users;
        }



        // ================== DEFAULT ADMIN ==================
        public void CreateDefaultAdminIfNotExists()
        {
            
            if (ReadUsers().Count == 0)
            {
                User user = new User("Admin", "admin");
                SaveUser(user);
               
            }
        }

        // ================== READ USERS ==================
        private Dictionary<string, string> ReadUsers()
        {
            var users = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (string line in File.ReadAllLines(_usersFile))
            {
                string[] parts = line.Split(_separator);
                if (parts.Length == 2)
                {
                    users[parts[0].Trim()] = parts[1].Trim();
                }
            }
            return users;
        }

        // ================== LOCK CHECK ==================
        public bool IsLocked(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return false;

            foreach (string line in File.ReadAllLines(_lockedFile))
            {
                if (line.Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // ================== SAVE USER ==================
        public bool SaveUser(User user)
        {
            if(user == null || String.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentException("Invalid User");
            }
            if (ReadUsers().ContainsKey(user.Username))
                throw new DuplicateEntryException("username");

            using (StreamWriter sw = File.AppendText(_usersFile))
            {
                sw.WriteLine(user.Username + _separator + user.Password);
            }
            return true;
        }

        // ================== VALIDATE LOGIN ==================
        public string ValidateLogin(User user)
        {
            if(user == null || String.IsNullOrWhiteSpace(user.Username))
            {
                return "failed";
            }

            if (IsLocked(user.Username)) return "locked";

            var users = ReadUsers();

            if (users.ContainsKey(user.Username) && users[user.Username] == user.Password)
            {
                ResetFailedAttempts(user.Username);
                return "success";
            }

            // Failed login
            int attempts = GetFailedAttempts(user.Username) + 1;
            SaveFailedAttempts(user.Username, attempts);

            if (attempts >= _maxAttempts)
            {
                LockAccount(user.Username);
                return "locked";
            }

            int attemptsLeft = _maxAttempts - attempts;
            return attemptsLeft.ToString();
        }

        
        private int GetFailedAttempts(string username)
        {
            string attFile = $"attempts_{username}.txt";
            if (File.Exists(attFile) && int.TryParse(File.ReadAllText(attFile), out int count))
                return count;
            return 0;
        }

        private void SaveFailedAttempts(string username, int attempts)
        {
            string attFile = $"attempts_{username}.txt";
            File.WriteAllText(attFile, attempts.ToString());
        }

        private void ResetFailedAttempts(string username)
        {
            string attFile = $"attempts_{username}.txt";
            if (File.Exists(attFile))
                File.Delete(attFile);
        }

        private void LockAccount(string username)
        {
            File.AppendAllText(_lockedFile, username + Environment.NewLine);
        }

        
        public void UnlockAccount(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return;

            var lines = new List<string>(File.ReadAllLines(_lockedFile));
            lines.RemoveAll(l => l.Trim().Equals(username, StringComparison.OrdinalIgnoreCase));
            File.WriteAllLines(_lockedFile, lines);

            ResetFailedAttempts(username);
        }
    }
}