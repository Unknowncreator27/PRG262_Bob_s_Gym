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

        private void EnsureFilesExist()
        {
            if (!File.Exists(_usersFile)) File.Create(_usersFile).Dispose();
            if (!File.Exists(_lockedFile)) File.Create(_lockedFile).Dispose();
        }

        // ================== DEFAULT ADMIN ==================
        public void CreateDefaultAdminIfNotExists()
        {
            if (ReadUsers().Count == 0)
            {
                User user = new User("Admin", "admin");
                SaveUser(user.Username, user.Password);
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
        public bool SaveUser(string username, string password)
        {
            if (ReadUsers().ContainsKey(username))
                throw new DuplicateEntryException("username");

            using (StreamWriter sw = File.AppendText(_usersFile))
            {
                sw.WriteLine(username + _separator + password);
            }
            return true;
        }

        // ================== VALIDATE LOGIN ==================
        public string ValidateLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return "failed";

            if (IsLocked(username)) return "locked";

            var users = ReadUsers();

            if (users.ContainsKey(username) && users[username] == password)
            {
                ResetFailedAttempts(username);
                return "success";
            }

            // Failed login
            int attempts = GetFailedAttempts(username) + 1;
            SaveFailedAttempts(username, attempts);

            if (attempts >= _maxAttempts)
            {
                LockAccount(username);
                return "locked";
            }

            int attemptsLeft = _maxAttempts - attempts;
            return attemptsLeft.ToString();
        }

        // ================== FAILED ATTEMPTS HELPERS ==================
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

        // ================== ADMIN UNLOCK ==================
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