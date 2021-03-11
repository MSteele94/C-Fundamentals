using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceClasses
{
    //enums are like string arrays, they index at 0. can change the index by setting first value = 1.
    //enums are basically a way of indexing and storing things. To categorize easier. 
    public enum DietType { Herbivore =1 , Omnivore, Carnivore}
    public class Animals
    {
        public Animals()
        {
            Console.WriteLine("This is an Animal Constructor.");
        }
        public string AnimalName { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }


        //virtual allows for this to be modified by any class that will inherit it. 
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
