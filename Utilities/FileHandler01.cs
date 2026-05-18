using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG262_Bob_s_Gym.Models;
using PRG262_Bob_s_Gym.Exceptions;


namespace PRG262_Bob_s_Gym.Utilities
{

    /// <summary>
    /// Handles all read / write ops for users text file
    /// \
    /// </summary>
    public static class FileHandler
    {
        private static readonly string filePath = "users.txt";

        /// <summary>
        /// Read all users from the text file
        /// </summary>
        /// 
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            if (!File.Exists(filePath))
            {
                // if the file doe not exist: Create it
                CreateDefaultAdmin();
                return GetAllUsers();
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('|');
                if(parts.Length >= 4)
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

        /// <summary>
        /// Save all users back to the text file
        /// 
        /// </summary>
        /// 
        public static void SaveAllUsers(List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (var user in users)
            {
                lines.Add($"{user.Username}|{user.Password}|{user.FailedAttempts}|{user.IsLocked}");
            }

            File.WriteAllLines(filePath, lines);
        }

        /// <summary>
        /// Creates a default admin account
        /// 
        /// </summary>
        /// 

        private static void CreateDefaultAdmin()
        {
            var admin = new List<User>()
            {
                new User("admin", "admin123")
            };
            SaveAllUsers(admin);
        }
        /// <summary>
        /// Updates a single user's login attempts and lock status
        /// 
        /// </summary>
        /// 
        public static void UpdateUser(User userToUpdate)
        {
            try
            {
                var users = GetAllUsers();
                var user = users.Find(u => u.Username == userToUpdate.Username);
                if (user != null)
                {
                    user.FailedAttempts = userToUpdate.FailedAttempts;
                    user.IsLocked = userToUpdate.IsLocked;
                    SaveAllUsers(users);
                }
            }
            catch (CustomExceptions.RecordNotFoundException)
            {

                throw new CustomExceptions.RecordNotFoundException(userToUpdate, "");
            }
        }
    }
}
