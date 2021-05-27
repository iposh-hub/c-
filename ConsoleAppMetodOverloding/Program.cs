using System;

namespace ConsoleAppMetodOverloding
{
    class Program
    {
        static void Main(string[] args)
        {

            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc) 
            {
                Console.WriteLine(outSayi);
            }
            else 
            {
                Console.WriteLine("Basarısız!");
            
            }
            //Topla(); yazarsam calısmaz cunku instance olusturmam gerekir
            Metodlar instance = new Metodlar();
            instance.Topla(4, 5, out int ToplamSonucu);
            Console.WriteLine(ToplamSonucu);

            //Metot Aşırı Yükleme-Overloading
            int ifade = 39;
            instance.EkranaYazdir(ifade.ToString()); // Ekrana Yazdir text istiyor 
            //Overloading yaptıktan sonra bu metodu artık int ile de kullanabiliyorum 
            instance.EkranaYazdir(ifade);

            string text1, text2;
            text1 = "ıpek ";
            text2 = "ivgen ";
            instance.EkranaYazdir(text1+text2);

        }
    }

    class Metodlar 
    {
    
        public void Topla(int a ,int b, out int outtoplam) 
        {

            outtoplam = a + b; 
            //return etmeme gerek yok out ile alabilirim
        
        }

        public void EkranaYazdir(string text) 
        {

            Console.WriteLine(text);
        }

        public void EkranaYazdir(int num)
        {

            Console.WriteLine(num);
        }

        // bir tekrarın overloading olabilmesi için metod adı ve imzası değişmemelidir
        // parametre türü ve sayisi değişebilir!

        public void EkranaYazdir(string text1,string text2)
        {

            Console.WriteLine(text1 + text2);
        }

    }
}
