using System;

namespace InterfacePatika
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus= new Focus();
            Console.WriteLine(focus.HerBrand().ToString());
            Console.WriteLine(focus.HerWheelNumber().ToString());
            Console.WriteLine(focus.HerColor().ToString());
        }
    }
    
    
}
