using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_Bob_s_Gym.Classes
{
    internal class User
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;  // In real app we would hash this
        public int FailedAttempts { get; set; } = 0;
        public bool IsLocked { get; set; } = false;

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
