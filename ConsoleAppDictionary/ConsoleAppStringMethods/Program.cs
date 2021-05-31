using System;

namespace ConsoleAppStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = "Our lesson in C# Welcome!";
            string variable2 ="C# Welcome!";
            //Length 
            Console.WriteLine(variable.Length);
            Console.WriteLine(variable2.Length);

            //ToUpper ToLower
            Console.WriteLine(variable.ToLower());
            Console.WriteLine(variable.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(variable, "Hello")); // sonuna ekliyor hello'yu 

            //Compare, CompareTo

            Console.WriteLine(variable.CompareTo(variable2));// 0,1,-1 uzunluğa gore  eşitse 0 büyükse 1 küçükse -1  eleman sayısı
            Console.WriteLine(String.Compare(variable,variable2,true)); //büyük küçük harf ignore et iki kelime birbirinin aynısı mı?? 0 : evet aynısı 
            Console.WriteLine(String.Compare(variable, variable2, false)); // 1: hayır aynısı değil 


            //Contains
            Console.WriteLine(variable.Contains(variable2));
            Console.WriteLine(variable.EndsWith("Welcome"));
            Console.WriteLine(variable.StartsWith("Hello"));

            //IndexOf
            Console.WriteLine(variable.IndexOf("CS"));

            //Inser
            Console.WriteLine(variable.Insert(0, "helloo"));

            //Padleft, PadRight 
            Console.WriteLine(variable + variable2.PadLeft(40, '*')); // totalde 36 eleman var toplamda 40 olacak sekilde bosluk bırakıyor 
            Console.WriteLine(variable.PadRight(50,'-') + variable2);

            //Remove 
            Console.WriteLine(variable.Remove(10)); //10.karakterden sonra siliyor tamamınConsole.WriteLine(variable.Remove(10));
            Console.WriteLine(variable.Remove(5,3)); //5. indexten itibaren 3 eleman sil 
            Console.WriteLine(variable.Remove(0,1)); //bas harfi siliyor 0. elemandan itibaren 1 tane sil 


            //Split
            Console.WriteLine(variable.Split(' ')[1]);

            //Substring 
            Console.WriteLine(variable.Substring(4)); // 4. elemandan itibaren tamamını getirir
            Console.WriteLine(variable.Substring(4,6)); // 4. indexten başlayarak 6 karakter getirdi








        }



    }
}
