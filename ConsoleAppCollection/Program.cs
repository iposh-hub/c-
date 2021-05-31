using System;
using System.Collections.Generic;

namespace ConsoleAppCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            //T--> object türündedir
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var num in sayiListesi) 
            {
                Console.WriteLine(num);
            
            }

            foreach(var color in renkListesi)
            {
                Console.WriteLine(color);

            }

            sayiListesi.ForEach(num => Console.WriteLine(num));
            renkListesi.ForEach(color => Console.WriteLine(color));
            //Listeden eleman çıkarma
            sayiListesi.Remove(4); // Elemanı çıkarıyor direk
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0); // 0. elemanı çıkar 
            renkListesi.RemoveAt(1); // 1. elemanı koleksiyondan çıkar
            sayiListesi.ForEach(num => Console.WriteLine(num));
            renkListesi.ForEach(color => Console.WriteLine(color));
            // Liste içerisinde Arama 
            if(sayiListesi.Contains(10)) 
            {
                Console.WriteLine("10 liste içerisinde bulundu!");

            }
            //Eleman ile Index'e erişme 
            Console.WriteLine(renkListesi.BinarySearch("Sari"));
            //Diziyi  List'e Çevirme 
            string[] hayvanlar = { "Kedi", "Köpek", "Kus" };
            List<string> hayvanListesi = new List<string>(hayvanlar);
            //Listeyi nasıl temizleriz
            hayvanListesi.Clear();

            //list içerisinde nesne tutmak
            List<Kullanicilar> userList = new List<Kullanicilar>();
            Kullanicilar user1 = new Kullanicilar();
            user1.Isim = "Mehmet";
            user1.Soyisim = "Yildirim";
            user1.Yas = 29;

            Kullanicilar user2 = new Kullanicilar();
            user2.Isim = "Yasemin";
            user2.Soyisim = "Yildiz";
            user2.Yas = 23;


            userList.Add(user1);
            userList.Add(user2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {

                Isim = "Deniz",
                Soyisim="Kurt",
                Yas=33,

            }) ;


            foreach (var x in userList) 
            {

                Console.WriteLine("Kullanıcı Adı: {0} ", x.Isim);
                Console.WriteLine("Kullanıcı Soyadı: {0}", x.Soyisim);
                Console.WriteLine("Kullanıcı Yası: {0}",x.Yas);

            }
            
            
           
        }


        public class Kullanicilar 
        {

            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}
