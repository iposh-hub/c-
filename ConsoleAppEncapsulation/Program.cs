using System;

namespace ConsoleAppEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Name = "Ayse";
            ogrenci1.SurName = "Yılmaz";
            ogrenci1.StudentNo = 293;
            ogrenci1.Hisclass = 3; // set degerini kaldırırsak sadece okuyabiliriz deger atamayız;
            ogrenci1.OgrenciInfoGetir();
            ogrenci1.SınıfAtlat();
            ogrenci1.OgrenciInfoGetir();

            Ogrenci ogrenci2 = new Ogrenci("Asli","Yildirim",992,1);
            ogrenci2.SınıfDusur();
            ogrenci2.SınıfDusur();
            ogrenci2.OgrenciInfoGetir();


        }
    }

    class Ogrenci
    {
        private string name;
        private string surName;
        private int studentNo;
        private int hisclass; //private prop. genellikle küçük harfle baslar
        private int yas;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int Hisclass 
        { get => hisclass;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf Degeri 1'den kucuk olamaz");
                    hisclass = 1; // private olan değişken kullanılıyor 
                }
                else 
                {
                    hisclass = value; 
                }
            
            
            }
        
        }

        public int Yas // bütün ogrencileri 1. sınıf olarak kabul ettim sınıf ta tanımlamamm gerekirdi ama hepsini 7 yasında farzettim ve değiştiremiyorum sadece okuyoprum
        { get 
            {
                return 7;
            } 
          
        }




        // Diğer sınıflardan korumak istiyorum ama aynı zamanda kontrollü bir biçimde açmak istiyorum 


        public Ogrenci() {}

        public Ogrenci(string name, string surName, int studentNo, int hisclass)
        {
            Name = name;
            SurName = surName;
            StudentNo = studentNo;
            Hisclass = hisclass;
        }

        public void OgrenciInfoGetir() 
        {

            Console.WriteLine("******Ogrenci Bilgileri********");

            Console.WriteLine("Ad:    {0}", this.Name);
            Console.WriteLine("Soyad:    {0}", this.SurName);
            Console.WriteLine("No:    {0}", this.StudentNo);
            Console.WriteLine("Class:  {0}",this. Hisclass);
            Console.WriteLine("Yas:  {0}", this.Yas);
        }



        public void SınıfAtlat() 
        {
            this.Hisclass += 1;
        }

        public void SınıfDusur()

        {
            this.Hisclass -= 1;
        }











    }
}
