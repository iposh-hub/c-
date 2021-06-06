using System;

namespace ExtensionHw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı ve soyadınızı aralarında boşluk olacak şekilde girin: ");
            string text= Console.ReadLine();
            string [] SuggestedEmail = text.SuggestEmail();
            
            foreach (var item in SuggestedEmail)
            {
                Console.WriteLine(item);
            }
            
        }
    }

    public static class Extension
    {
           public static string [] SuggestEmail(this string text) 
           {
                string textlowercase = text.ToLower();
                Random random = new Random();
                string sayi1 = Convert.ToString(random.Next(0, 10));
                string sayi2 = Convert.ToString(random.Next(0, 10));
                
                string[] list = text.Split(" ");
                string email = string.Join("_", list);
                string email1= email + sayi1 + sayi2 + "@gmail.com";
                string email2 = list[1] + "." + sayi1 + sayi2 + "@gmail.com";
                string[] emaillist = { email1, email2 };
                return emaillist;
           } 
    
    } 
}
