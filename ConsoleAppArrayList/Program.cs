using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList(); //arrayList isimli bir ArrayList olusturdum 
            //arrayList.Add("Ayse");
            //arrayList.Add(2);
            //arrayList.Add(true);
            //arrayList.Add('A');

            //foreach (var item in arrayList)
            //{
                //Console.WriteLine(item);
           // }

            //içerisindeki verilere erişim;
            //Console.WriteLine(arrayList[1]);

            //Add Range
            Console.WriteLine("**** Add Range *****");
            //string[] renkler = {"Kırmızı","Sarı","Yesil" };
            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5 };
            //arrayList.AddRange(renkler);
            arrayList.AddRange(sayilar);



            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            // SORT
            arrayList.Sort();  //sadece int olsaydı karışık ya sıralamayacak büyükten küçüğe 
            Console.WriteLine(arrayList);


            //BinarySearch 
            Console.WriteLine(arrayList.BinarySearch(4));

            //Reverse 
            Console.WriteLine("*****Reverse*****");
            arrayList.Reverse();
            foreach (var item in arrayList) 
            {
                Console.WriteLine(item);            
            }
            arrayList.Clear();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
