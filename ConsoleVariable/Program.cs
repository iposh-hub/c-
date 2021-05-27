using System;

namespace ConsoleVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //string degısken = 'plant';
            //string kitap = null;
            //byte b = 5; //bellekte 1 byte yer kaplar 0-255
            //sbyte s = 5; //bellekte 1 byte -128-127 arasında değer alabilir
            //short s = 5;      // bellekte 2 byte 
            //ushort us = 5; //  bellekte 2 byte 0 dan küçük değerleri alamıyor
            //Int16 int16 = 2; // 2byte 
            //int a = 2; // 4 byte 
            Int32 b = 2; // 4 byte 
            Int64 c = 2; // 8byte 
            //uint ui = 2;  // 4 byte
            //long i = 4; //  8 byte  büyük sayılarda 
            //ulong i = 4; // 8 byte negatif değer almıyor
            //float f = 5; // 4 byte integer kadar 
            //double d = 5; // 8byte 
            //decimal de = 5; //16 byte 

            //char tek karakter tutuyor!
            //char ch = "A"; // 2 byte yer kaplar
            //string name = "ıpek" // sonsuz yer kaplar 


            //bool bl = true;
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);

            //object o1 = "x";
            //object o2 = "y";
            //object o3 = 4;
            //object o4 = 4.3;

            //string str1 = " ";
            //string str12 = null;
            //string str1 = string.Empty;
            //str1 = "Zikriye Ürkmez";
            string name, surname, fullname;
            name = "ıpek ";
            surname = "ivgen";
            fullname = name + surname;
            Console.WriteLine(fullname);
            string str20 = "20";

            int int20 = 20;
            int sum = int20 + Convert.ToInt32(str20);

            Console.WriteLine(sum);

            string toplam = str20 + int20.ToString();
            Console.WriteLine(toplam);


            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Today.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
