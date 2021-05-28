using System;

namespace ConsoleAppConstructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********Calısan 1 ******************");
            Calisan calisan1 = new Calisan("Ayse","Kara", 23425634,"Insan Kaynakları");
            calisan1.CalisanBilgileri();


            Console.WriteLine("********Calısan 2 ******************");
            Calisan calisan2 = new Calisan("Deniz", "Yılmaz", 12455794, "Bilisim");
            calisan2.CalisanBilgileri();

            Console.WriteLine("********Calısan 3 ******************");

            Calisan calisan3 = new Calisan("Mehmet", " Mutlu");
            calisan3.CalisanBilgileri();

            //Calisan calisan1 = new Calisan();
            //calisan1.Ad = "Ayse";
            //calisan1.Soyad = "Kara";
            //calisan1.No = 23425634;                   nesne olustuktan sonra belirlemiştim 
            //calisan1.Departman = "İnsan Kaynakları";
            //calisan1.CalisanBilgileri();
            //Console.WriteLine("**********************");

            //Calisan calisan2 = new Calisan();
            //calisan2.Ad = "Deniz";
            //calisan2.Soyad = "Yılmaz";
            //calisan2.No = 12455794;
            //calisan2.Departman = "Bilisim";
            //calisan2.CalisanBilgileri();
        }
    }


    class Calisan
    {

        public string Ad; // property 
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri() // metod

        {
            Console.WriteLine("Calısan Adi:  {0}  ", Ad);

            Console.WriteLine("Calısan Soyadi:  {0}  ", Soyad);
            Console.WriteLine("No:  {0}  ", No);
            Console.WriteLine("Departman: {0} ", Departman);

        }
        // kurucu fonksiyon yazalım nesne olustuktan sonra property eklemek yerine
        //nesne olusurken belirlemek istiyorum

        //Kurucu fonk public olacak ve sınıfın ismini alacak 
        //metottan farkı void,string, yani bir imzası yok 

        public Calisan(string name,string surname, int no, string department)  // kurucu metod 
        {

            this.Ad = name;
            this.Soyad = surname;
            this.No = no;
            this.Departman = department;
        }


        public Calisan(string name, string surname)  // kurucu metod overloading sadece isim-soyisimle kayıt edeyim 
        {

            this.Ad = name;
            this.Soyad = surname;
        }
        public Calisan() {} // hiçbir parametre almayan bir constructor yazıyorum

    }




}
