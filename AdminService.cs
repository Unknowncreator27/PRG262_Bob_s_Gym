using PRG262_Bob_s_Gym.Models;
using PRG262_Bob_s_Gym.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace PRG262_Bob_s_Gym.Utilities
{
    public static class AdminService
    {
        private static readonly string MASTER_ADMIN_PASSWORD = "Admin2026";

        /// <summary>
        /// Validates the master admin password
        /// </summary>
        public static bool ValidateAdminPassword(string password)
        {
            return password == MASTER_ADMIN_PASSWORD;
        }

        /// <summary>
        /// Gets all locked accounts
        /// </summary>
        public static List<User> GetLockedAccounts()
        {
            try
            {
                var allUsers = FileHandler.GetAllUsers(@"users.txt");
                return allUsers.Where(u => u.IsLocked).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving locked accounts: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Unlocks a specific account
        /// </summary>
        public static bool UnlockAccount(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            try
            {
                var users = FileHandler.GetAllUsers(@"users.txt");
                var user = users.Find(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

                if (user == null)
                    return false;

                user.IsLocked = false;
                user.FailedAttempts = 0;

                FileHandler.SaveAllUsers(users);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error unlocking account: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Unlocks ALL locked accounts (emergency function)
        /// </summary>
        public static int UnlockAllAccounts()
        {
            try
            {
                var users = FileHandler.GetAllUsers(@"users.txt");
                int count = 0;

                foreach (var user in users)
                {
                    if (user.IsLocked)
                    {
                        user.IsLocked = false;
                        user.FailedAttempts = 0;
                        count++;
                    }
                }

                if (count > 0)
                    FileHandler.SaveAllUsers(users);

                return count;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error unlocking all accounts: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Optional: Verify admin password with UI feedback
        /// </summary>
        public static bool VerifyAdminPassword(string password)
        {
            return ValidateAdminPassword(password);
        }
    }
}