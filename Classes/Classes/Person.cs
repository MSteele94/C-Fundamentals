using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes
{

    public class Person
    {
        public string FullName
        {
            get
            {
                return $"{FirstName}{LastName}";
            }
        }

        //this is a property of the "person class"
        public string FirstName { get; set; }


        //this shows what a "get; set;" does in the long form
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public DateTime DateOfBirth { get; set; }
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

        // you can use other properties in different projects
        public Vehicle Transport { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;


        }

    }
}
