using System;

namespace ConsoleAppFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen ibr sayı giriniz:  ");
            int sayac = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<=sayac; i++ ) 
            {
                if (i%2 !=0) 
                {
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine("*****1-1000 arasındaki tek ve çift sayıların toplamı");
            int TekToplam, CiftToplam;
            TekToplam = 0; CiftToplam = 0;
            for (int i =1; i<=1000; i+=1) 
            {
                if (i%2==0) 
                {
                    CiftToplam += i;
                }
                else 
                {
                    TekToplam += i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı: " +TekToplam);
            Console.WriteLine(" Çift Sayiların Toplamı: " + CiftToplam);

            for (int i=1; i<10; i+=1) 

            {
                
                if (i == 4) 
                {
                    break;
                }
                Console.WriteLine(i); // i=4 olunca döngüyü sonlandırdı

            }


            for (int i = 1; i < 10; i += 1)

            {
                
                if (i == 4)
                {
                    continue;
                }

                Console.WriteLine(i); // i=4 olunca döngüyü sonlandırdı
            }








        }   





    }
}
