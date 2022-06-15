using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        #region konstruktory
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {

        }
        #endregion

        #region vlastnosti
        public string FirstName { get; set; } = "John";

        public string LastName { get; set; } = "Doe";

        public string FullName
        {
            get
            {
                return GetFullName();
            }
        }

        public DateTime DateOfBirth { get; set; }

        public Address HomeAddress { get; set; }
                                        = new Address();
        public string Email { get; set; }

        public List<Contract> Contracts { get; set; }
                                    = new List<Contract>();
        #endregion

        #region metody
        public override string ToString()
            => $"{FirstName} {LastName}";


        public int Age()
        {
            DateTime today = DateTime.Today;

            int age = today.Year - DateOfBirth.Year;

            if (today.Month < DateOfBirth.Month ||
           ((today.Month == DateOfBirth.Month) && (today.Day < DateOfBirth.Day)))
            {
                age--;  //birthday in current year not yet reached, we are 1 year younger ;)
            }

            return age;
        }

        public string GetFullName()
            => $"{FirstName} {LastName}";

        #endregion

    }
}
