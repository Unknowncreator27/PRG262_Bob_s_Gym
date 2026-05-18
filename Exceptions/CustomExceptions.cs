using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_Bob_s_Gym.Exceptions
{
    internal class CustomExceptions: Exception
    {
        // --- AUTHENTICATION EXCEPTIONS ---

        // Requirement: "After three failed login attempts, lock the account"
        public class AccountLockedException : Exception
        {
            public AccountLockedException(string username)
                : base($"The account for '{username}' has been locked. Please contact the administrator to unlock it.") { }
        }

        // --- FORM & VALIDATION EXCEPTIONS ---

        // Requirement: "Implement necessary validations for the login form" & "adding member records"
        public class IncompleteFormException : Exception
        {
            public IncompleteFormException()
                : base("All required fields must be filled out before submitting.") { }
        }

        // Requirement: "Membership Start Date" vs "Membership End Date"
        public class InvalidMembershipDateException : Exception
        {
            public InvalidMembershipDateException()
                : base("The Membership End Date must be after the Start Date.") { }
        }

        // Requirement: Validation for Date of Birth
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(int minAge)
                : base($"Member does not meet the minimum age requirement of {minAge} years.") { }
        }

        // --- DATABASE & CRUD EXCEPTIONS ---

        // Requirement: "CRUD Operations... search functionalities"
        public class RecordNotFoundException : Exception
        {
            public RecordNotFoundException(string entity, string criteria)
                : base($"{entity} '{criteria}' was not found in the database.") { }
        }

        // Requirement: "Class and Training Program Management... Capacity"
        public class ClassCapacityReachedException : Exception
        {
            public ClassCapacityReachedException(string className)
                : base($"The class '{className}' is full.") { }
        }

        // Requirement: Handling duplicate IDs or Staff usernames
        public class DuplicateEntryException : Exception
        {
            public DuplicateEntryException(string field)
                : base($"An entry with this {field} already exists. Please use a unique value.") { }
        }

        // --- FILE HANDLING EXCEPTIONS ---

        // Requirement: "Store usernames and passwords in a text file"
        public class FileDataCorruptedException : Exception
        {
            public FileDataCorruptedException(string fileName)
                : base($"The data in '{fileName}' is not in the correct format and cannot be read.") { }
        }

        public class FileNotFoundException: Exception
        {
            public FileNotFoundException(string file): base($"Cannot find '{file}'.") { }
        }






    }
}
