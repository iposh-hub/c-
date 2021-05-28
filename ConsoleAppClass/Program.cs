using System;

namespace ConsoleAppClass
{
    class Program
    {   

        //
        static void Main(string[] args)
        {
            //SözDizimi
            //class SinifAdi 
            //{
            //  [Erişim Belirleyici] [Veri Tİpi ] OzellikAdı --> property

            //  [Erişim Belirleyici] [Geri Dönüş Tipi] Method Adı(Paremetre Listesi)
            //  {
            //          Metod komutları
            //  }
            //
            //}Erişim Belirleyiciler
            // * Public --> farklı sınıflarda çalışır 
            // * Private --> sadece o sınıfta çalışır 
            // * Internal  --> Sadece bulunduğu projelerden erişilebilir 
            //* Protected --> o sınıfta ya da ondan kalıtım alan sınıflarda tanımlanır 


            //instance tanımlıyorumm
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayse";
            calisan1.Soyad = "Kara";
            calisan1.No = 23425634;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Yılmaz";
            calisan2.No = 12455794;
            calisan2.Departman = "Bilisim";
            calisan2.CalisanBilgileri();
        }






        class Calisan 
        {

            public string Ad; // property 
            public string Soyad;
            public int No;
            public string Departman;

            public void CalisanBilgileri () // metod
            {
                Console.WriteLine("Calısan Adi:  {0}  " , Ad);
                Console.WriteLine("Calısan Soyadi:  {0}  ", Soyad);
                Console.WriteLine("No:  {0}  ", No);
                Console.WriteLine("Departman: {0} ", Departman);
               
            }
        
        
        }
    }
}
