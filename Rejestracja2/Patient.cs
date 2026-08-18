using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracja2
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Patient(string firstName, string lastName, string pesel, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
