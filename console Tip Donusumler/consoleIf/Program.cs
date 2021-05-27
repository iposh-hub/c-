using System;

namespace ConsoleAppIfStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın!");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }

            else if (time > 18 && time<22 )
            {
                Console.WriteLine("İyi Aksamlar");
            }

            else 
            {
                Console.WriteLine("İyi Geceler");

            }
            string sonuc = time <= 18 ? "İyi Günler" : "İyi Aksamlar";
            sonuc = hour >= 6 && hour < 11 ? "Günaydın" : hour <= 18 ? "İyi Günler" ;


            Console.WriteLine(sonuc);
            

        }
    }
}
