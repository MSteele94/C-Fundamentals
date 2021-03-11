using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Loop_Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoopChallenges1()
        {
            string longWord = "Supercalifragilisticexpialidocious";
            foreach (char letter in longWord)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
            Console.WriteLine($"The number of letters in the word is: " + longWord.Length);

            foreach (char letter in longWord)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine('L');
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
        }
    }
}

