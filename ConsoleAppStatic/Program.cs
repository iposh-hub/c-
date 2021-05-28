using System;

namespace ConsoleAppStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calisan calisan1 = new Calisan("Asli","Koparipek","IK");
            Console.WriteLine(Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Ali", "Yilmaz", "IK");
            Calisan calisan3 = new Calisan("Metin", "Yildirim", "IK");
            Calisan calisan4 = new Calisan("Kerem", "Korkmaz", "IK");
            //Calisan calisan5 = new Calisan("Nazli", "Aydin", "IK");
            //Calisan calisan6 = new Calisan("Yasemin", "Mutlu", "IK");
            Console.WriteLine(Calisan.CalisanSayisi);
            calisan1.BilgileriYazdir();
            calisan2.BilgileriYazdir();
            calisan3.BilgileriYazdir();
            calisan4.BilgileriYazdir();
            //calisan5.BilgileriYazdir();
            //calisan6.BilgileriYazdir();
            Console.WriteLine("Toplama İslemi Sonucu: {0} ",Islemler.Topla(100,200));
            Console.WriteLine("Cıkarma İslemi Sonucu: {0} ", Islemler.Cıkar(100, 200));


        }
    }

    class Calisan
    {

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        // olusturduğumuz her nesne de en son atanan değeri getirecektir sınıf bazlı çağrıyoruz çünkü 

        private string personnelName;
        private string personnelSurname;
        private string personnelDepartment;  // bu ozelliklere property atamıyorum sadece personeli tanımlarken kurucu metodta tanımlayacağım ve baslangıcta tanımladığım isimlere ulasamaycağım 


        static Calisan() // static kurucu metot Calisan sınıfıyla erisebileceğim ve Calisan Sınıfı içerisinden değiştirebiliyorum 
        {

            calisanSayisi = 0;
        
        }
        
        public Calisan(string personnelName, string personnelSurname, string personnelDepartment) // kurucu metot public ve sınıfın adıyla
        {
            this.personnelName = personnelName;
            this.personnelSurname = personnelSurname;
            this.personnelDepartment = personnelDepartment;
            calisanSayisi += 1;

        }

        public void  BilgileriYazdir() // metod
        {

            Console.WriteLine("Ad:  {0}" ,this.personnelName);
            Console.WriteLine("Soyad:  {0}", this.personnelSurname);
            Console.WriteLine("Deoartman:  {0}", this.personnelDepartment);
        }
    }

    static class Islemler // static sınıfa nesne atanmaz  // statik sınıflara kalıtım işlemi uygulanamaz
    {
        public static long Topla(int num1, int num2)
        {
            return (num1 + num2);
        }

        public static long Cıkar(int num1, int num2)
        {
            return (num1 - num2);
        }


    }
}
