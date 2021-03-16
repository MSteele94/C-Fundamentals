using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Challenges
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }


        //no setter for ID because you don't want people to be able to set their own ID or people could have the same ID number

        public int ID { get; }

        //blank constructor
        public User()
        {

        }
        //full constructor
        public User(string firstName, string lastName,DateTime dateOfBirth, int idNum)
        {
            firstName = FirstName;
            lastName = LastName;
            dateOfBirth = DateOfBirth;
            idNum = ID;
        }
        public string FullName
        {
            get
            {
                return $"{FirstName}{LastName}";
            }
        }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }
    }
}
