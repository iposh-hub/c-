using System;

namespace GreetingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings();
            greetings.Greet();
        }


        public class Greetings
        {
            
            public void Greet() 
            {
                EnglishGreeting englishGreeting = new EnglishGreeting();
                englishGreeting.GreetingsInEnglish();

            }  

        }

        public class EnglishGreeting 
        {
            public void GreetingsInEnglish()
            {
                Console.WriteLine("Hello, How's your day been?");

            }

        }
    }
}
