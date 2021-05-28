using System;

namespace ConsoleAppEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int temp = 22;
            if (temp <= (int)(HavaDurumu.Normal))
            {

                Console.WriteLine("Disari çikmak için biraz daha bekleyelim");
            }

            else if (temp > (int)HavaDurumu.Sicak) 
            {
                Console.WriteLine("Disari çikmak için çok sicak bir gün");

            }

            else if (temp>= (int)HavaDurumu.Normal && temp < (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Hadi disari cikalim!");

            }

        }
    }

    enum Gunler 
    {
    
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar,
    
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak= 25,
        CokSicak=30,
    }
}
