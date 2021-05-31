using System;

namespace ConsoleAppHazırMetodlarDateTimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // Monday
            Console.WriteLine(DateTime.Now.DayOfYear); // Yılın 151. günü

            Console.WriteLine(DateTime.Now.ToLongDateString()); //31 Mayıs 2021 Pazartesi 
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 31.05.2021


            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //31
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Mon 
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Monday

            Console.WriteLine(DateTime.Now.ToString("MM")); //05
            Console.WriteLine(DateTime.Now.ToString("MMM")); //May  /Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // May  / April 

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));// 2021
            Console.WriteLine("*****Math Lib****");

            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10)); //10 radyanın sin değeri 
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));


            Console.WriteLine(Math.Ceiling(22.3)); //tavan değerine çevrilir 23
            Console.WriteLine(Math.Round(22.3)); // 22
            Console.WriteLine(Math.Round(22.7)); // 23 e yuvarlar
            Console.WriteLine(Math.Floor(22.3));// 22 taban değere yuvarlar

            Console.WriteLine(Math.Max(6,3));
            Console.WriteLine(Math.Min(6, 3));

            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Sqrt(100));
            Console.WriteLine(Math.Log(100)); // 100'ün e tabanındaki logaritmik karşılığını getirir
            Console.WriteLine(Math.Exp(3)); // e^3 
            Console.WriteLine(Math.Log10(100)); // 100'ün log10 tabanındaki değeri 



        }
    }
}
