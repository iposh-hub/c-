using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("b: ");
                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine(c);

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }

            finally 
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
