using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;

            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine("Age is over 17:" + isAdult);

            int numOne = 5;
            // ? mark means to ask if expression is true //  the left side of the colon shows if expression is true
            int numTwo = (numOne == 5) ? 30 : 20;
            Console.WriteLine(numTwo);

            Console.WriteLine((numTwo == 30) ? "true" : "false");
        }
    }
}
