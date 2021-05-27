using System;

namespace MetotTanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);
            Console.WriteLine("*****Aynı Class yeni fonksiyon--- Topla*******");
            int result_func=Topla(a,b);
            Console.Write(result_func);

            Console.WriteLine("*****Methods Class*******");

            Methods instance = new Methods();
            int result_inc_1 = instance.ArttirVeTopla(ref a,ref b);
            instance.EkranaYazdir(result_inc_1.ToString());
            instance.EkranaYazdir(Convert.ToString(a + b));

        }

        // Aynı class içinde bu işi yapacak baska bir fonksiyon yazalım
        // Ana classımız statik olduğu için yazacağımız fonksiyonda static olmalı yoksa çağramayız
        // void: bir değer dönmüyorum biz burada int deger donecegiz 


        static int Topla(int val1,int val2) 
        {
            return (val1 + val2);
            
        }
    }


    class Methods // yeni bir sınıf olusturdugumuzda baska bir sınıfta islem yapabilmemiz için instance olusturmalıyız
    {
        public void EkranaYazdir(string veri) // public seklinde belirtmezsek sadece Methods sınıfından ulasabiliriz
        {

            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int val1, ref int val2) 
        {   // ref int val1 global olmus oldu yani her yerde +1 fazla olarak calısacak 

            val1 += 1;
            val2 += 1;
            return val1 + val2;
        
        }
            

    } 
   
}
