using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            // Addition '+'
            int sum = a + b;

            sum += 3;  // this is shorthand addition
            Console.WriteLine(sum);

            //subtraction ' - ' 
            int difference = a - b;
            //difference -=3; (notes)

            Console.WriteLine($"difference : {difference}");

            //Multiplication '*'
            int product = a + b;

            Console.WriteLine($"product : {product}");

            //division ' / '
            int quotient = a / b;
            Console.WriteLine($"quotient : {quotient}");

            //Modulus 
            int remainder = a % b;
            Console.WriteLine($"remainder : {remainder}");

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1978, 1, 1);

            TimeSpan timeSpan = now - someday;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);

            //-------------

            //add two numbers

        }
    }
}
