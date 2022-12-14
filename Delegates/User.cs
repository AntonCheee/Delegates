using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public int PhoneNumber { get; set; }

        public User(string firstName, string lastName, DateTime dateOfBirthday, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirthday = dateOfBirthday;
            PhoneNumber = phoneNumber;
        }
    }
}
