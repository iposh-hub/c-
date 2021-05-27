using System;

namespace ConsoleStart
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName, UserSurname, UserEmail;
            Console.Write("Please enter your name: ");
            UserName = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            UserSurname = Console.ReadLine();
            Console.Write("Please enter your email: ");
            UserEmail = Console.ReadLine();


            Console.WriteLine("You successfully logged in with  " + UserEmail);
            Console.WriteLine(UserName + " " + UserSurname + " Welcome! ");
        }
    }
}
