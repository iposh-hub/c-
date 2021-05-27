using System;

namespace ConsoleDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama 

            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "kus", "maymun" };

            int[] dizi;
            dizi = new int[5]; // 5 elemanı var 

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "mavi";
            hayvanlar[3] = "fare";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            
            
            
            
            
            Console.Write(" Merhaba, Kaç tane sayı toplamak istiyorsunuz: ");
            int listLength = Convert.ToInt32(Console.ReadLine());

            int[] list = new int[listLength];
            int i = 0;
            int Toplam = 0;
            while (i < listLength)
            { 
                Console.Write("Sayıları girin:");
                int number = Convert.ToInt32(Console.ReadLine());
                list[i] = number;
                i += 1;
            }
            foreach (var num in list) 
            {
                Toplam += num;
            }

            Console.WriteLine("Sayıların Toplamı: "+ Toplam);
            Console.ReadLine();

        }
    }
}
