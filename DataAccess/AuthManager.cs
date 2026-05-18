using PRG262_Bob_s_Gym.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PRG262_Bob_s_Gym.Classes.CustomExceptions;

namespace PRG262_Bob_s_Gym.DataAccess
{
    public class AuthManager
    {
        private const string FilePath = "staff.txt";

        public bool Login(string username, string password, int currentAttempts)
        {
            if (currentAttempts >= 3)
            {
                LockAccount(username);
                throw new AccountLockedException(username);
            }

            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException("The system authentication registry file is missing.");
            }

            // Read the file and check credentials...
            // If password wrong, return false (which will increment the attempt counter in UI)
            return true;
        }

        private void LockAccount(string username)
        {
            // Code to rewrite staff.txt and set status to 'Locked'
        }
    }
}