using System;

namespace ConsoleAppRecursion_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif- Öz Yinemeli 
            //3^4= 3*3*3*3

            //for ile
            int result = 1;
            for (int i = 1; i < 5; i++) 
            {

                result*= 3;
                
            }
            Console.WriteLine(result);
            Islemler instance = new(); //ıslemler sınıfının orneğini aldım
            int sonuc2 = instance.Expo(3, 4);
            Console.WriteLine(sonuc2);

            string text = "Ipek Ayse Necla Ivgen";
            bool VarMı = text.CheckSpaces();
            if (VarMı)
            { 
                Console.WriteLine(text.RemoveWhiteSpaces());
            }
            Console.WriteLine(text.MakeUpperCase());
            Console.WriteLine(text.MakeLowerCase());

            int[] series = { 9,3,6,2,1,5,0 };
            series.SortArray();
            series.EkranaYazdir();
            int a = 10;
            Console.WriteLine(a.IsEvenNumber());
            string t = "table";
            Console.WriteLine(t.GetFirstCharacter());
        }
    }


    class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
            //Expo(3,4)
            //Expo(3,3)*3*3
            //Expo(3,2)*3*3*3
            //Expo(3,1)*3*3*3
            //=3*3*3*3 

        }
    }


    public static class Extensions  // nesne yaratmadan ulasabilirim static bu nedenle var
    {

        public static bool CheckSpaces(this string param)
        {

            return param.Contains(" ");


        }

        public static string RemoveWhiteSpaces(this string param)
        {

            string[] dizi = param.Split(" ");
            return string.Join("", dizi);

        }

        public static string MakeUpperCase(this string param)
        {

            return param.ToUpper();

        }

        public static string MakeLowerCase(this string param)
        {

            return param.ToLower();

        }

        public static int[] SortArray(this int[] param)
        {

            Array.Sort(param);
            return param; 

        }

        public static void EkranaYazdir(this int[] param) 
        {
            
            foreach(var item in param) 
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber (this int param) 
        {
            return (param % 2 == 0);
     
        }

        public static string GetFirstCharacter(this string param) 
        {
            return param.Substring(0, 1);

        }








    }
}
