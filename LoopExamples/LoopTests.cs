using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void WhileLoops()
        {
            //just for setup...
            int total = 1;

            //Keep running as long as total isn't 10
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }

                total++;
            }

            //new setup
            Random random = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                //0 inclusive, 20 exclusive so its 19 (0-19)
                someCount = random.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

        }
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //initialization   conditional   //increment
            for (int i = 1; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]}");
            }
        }
        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }

            //string is an array of char
            string MyName = "Terry Eugene Edward Brown";
            foreach (char letter in MyName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }
        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator++;
            } while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is False!!");
            } while (false);


            while (false)
            {
                // linter is telling us code is unreachable (in background of VS)
                Console.WriteLine("My while condition is false");
            }

        }
    }
}
