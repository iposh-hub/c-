using System;
using System.Collections.Generic;

namespace ConsoleAppDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1, "Ayse Yılmaz");
            users.Add(2, "Ahmet Kaya");
            users.Add(3, "Yıldırım Kaymaz");
            users.Add(4, "Ozcan Cosar");
            //Dizinin elemanlarına erişim 
            Console.WriteLine("***Elemanlara Erişim****");
            Console.WriteLine(users[3]); // indexini yazıyorsun
            foreach (var item in users) 
            {

                Console.WriteLine(item);
            }

            //Count;

            Console.WriteLine("***Count****");

            Console.WriteLine(users.Count);
            //Remove 
            Console.WriteLine("*****Remove****");
            users.Remove(2);
            foreach (var item in users)
            {

                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("****Keys***");
            foreach (var item in users.Keys)
            {

                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("****Values***");

            foreach (var item in users.Values)
            {

                Console.WriteLine(item);
            }


        }
    }
}
