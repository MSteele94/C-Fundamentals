using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;

            string declared;
            declared = "this is initialized.";

            string declareAndInitialize = "This is both declaring and initializing.";

            string firstName = "Michael";
            string lastName = "Steele";

            string concatenatedFullName = firstName +  " " + lastName;

            string interpolationFullName = $"{firstName} {lastName}";

            //composite always has the "string.Format"
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolationFullName);
            Console.WriteLine(compositeFullName);
            
        }
        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample };
            string[] somethingDifferent = { "some", "word" };
            
            //Arrays start with 0, not 1

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            somethingDifferent[1] = "idk";
            Console.WriteLine(somethingDifferent[1]);

            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);

            //always select the "using" option if available when using the lightbulb quickfix

            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("First string for our list");

            listOfInts.Add(123456);

            Console.WriteLine(listOfInts[0]);
            //queue will display first item
            //queue is good for help line application like a call center
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm Next");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            
            // Dictionaries have infinite amounts
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");

            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);
            
            
            //these are other collection types

            //sorted list will always put the key where it goes
            //rarely used
            SortedList<int, string> sortedKeyandValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);
        }
    }
}
