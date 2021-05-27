using System;

namespace ConsoleAppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            // Expression
            switch (month) 
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Subat Ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız");
                    break;
                case 5:
                    Console.WriteLine("Mayıs Ayındasınız");
                    break;
                default:
                    Console.WriteLine("Opps!");
                    break;
               
            }

            switch (month) 
            {

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    break;





            }






        }
    }
}
