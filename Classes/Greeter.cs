using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        //emtpy brackets will only display "Hello"
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        Random _random = new Random();
        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Good Morning", "Whats up", "Whats up Dawg", "Howdy" };
            int randomNumber = _random.Next(0, availableGreetings.Length);
            //Element matches random number to one of the greetings
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            Console.WriteLine($"{randomGreeting}");
        }
    }
}
