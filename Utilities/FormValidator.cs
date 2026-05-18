using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PRG262_Bob_s_Gym.Classes.CustomExceptions;

namespace PRG262_Bob_s_Gym.Utilities
{
    public static class FormValidator
    {
        // Your teammates can call this on ANY form to check for empty fields
        public static void CheckRequiredFields(params string[] fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    throw new IncompleteFormException();
                }
            }
        }

        // Checks membership dates
        public static void ValidateMembershipDates(DateTime start, DateTime end)
        {
            if (end < start)
            {
                throw new InvalidMembershipDateException();
            }
        }

        // Checks numeric values like Capacity or Duration
        public static int ValidateNumericInput(string input, string fieldName)
        {
            if (!int.TryParse(input, out int result))
            {
                throw new FormatException($"{fieldName} must be a valid whole number.");
            }
            if (result <= 0)
            {
                throw new ArgumentException($"{fieldName} must be greater than zero.");
            }
            return result;
        }
    }
}