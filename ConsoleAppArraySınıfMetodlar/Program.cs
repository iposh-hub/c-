using System;

namespace ConsoleAppArraySınıfMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23,12,4,86,72,3,11,17 };
            Console.WriteLine("Sırasız Dizi");
            foreach (var item in sayiDizisi) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");
            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");

            //Clear 
            Console.WriteLine("****** Array Clear********");
            Array.Clear(sayiDizisi, 2, 2); // 2. elemandan basla 2 eleman temizle == değerini sıfır yapıyor 
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************");

            //Reverse
            Console.WriteLine("****** Reverse********");
            Array.Reverse(sayiDizisi);  // diziyi tersine çeviriyor bastaki eleman sondaki oluyor 
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************");

            //IndexOf() 
            Console.WriteLine("****** IndexOf()********");
            int index=Array.IndexOf(sayiDizisi,23);  // virgülden sonraki elemanın kacıncı indexte olduğunu söylüyor 

            Console.WriteLine(index);
            Console.WriteLine("************************");

            //Resize

            Console.WriteLine("****** Resize********");
            Array.Resize <int>(ref sayiDizisi, 9);  // Dizi 8 elemanlıydı 9 yaptık
            sayiDizisi[8] = 99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************************");



        }

    }
}
