using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings(new GreetingsInSpanish());
            greetings.PrintGreetings();
        }
    }

    
    public class Greetings 
    {
        private IGreeting greetPerson;
        public Greetings (IGreeting greeting) 
        {
            this.greetPerson = greeting;
        }

        public void PrintGreetings() 
        {
            greetPerson.Greet();
        
        }
    
    
    }
    
    
    
   
    
    public interface IGreeting 
    {
        void Greet();
    
    }

    public class GreetingsInEnglish : IGreeting
    {
        public void Greet()
        {
            Console.WriteLine( "Hello, How's your day beenn?");
        }
    }

    public class GreetingsInItalian : IGreeting
    {
        public void Greet()
        {
            Console.WriteLine("Ciao, Come è stata la tua giornata? ");
        }
    }

    public class GreetingsInSpanish : IGreeting
    {
        public void Greet()
        {
            Console.WriteLine("Hola, Coma ha sido tu dia?");
        }
    }
}
