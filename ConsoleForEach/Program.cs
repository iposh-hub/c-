using System;

namespace ConsoleForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lütfen bir sayi girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int start = 1;
            int Toplam=0;
            while (start <=sayi ) 
            {
                Toplam+=start;
                start+=1;
            
            }

            Console.WriteLine("Sayıların Ortalaması: " + Toplam/sayi);

            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character ++;
            
            }


            Console.WriteLine("***********ForEach*************");

            string[] cars = { "BMW", "Renault", "Nissan", "Toyota" };
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            } 

            Console.ReadLine();
        }
    }
}
