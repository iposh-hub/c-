using System;

namespace ConsoleAppOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama Ve İşlemli Atama
            int  y, a, b;
            double x = 3;
            y = 4;
            b = y + 2;
            a=y+2;
            x /= 2;
            Console.WriteLine(x);
            Console.WriteLine(b);
            Console.WriteLine(a);

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");

            }
            else if (isSuccess | isCompleted) 
            {

                Console.WriteLine("Great!");
            
            }

            else if  (isSuccess && !isCompleted)
            {
                Console.WriteLine("You are successfull but all your works haven'been completed yet!");
            
            
            }
            //İlişkisel Operatörler

            int t, z;
            t = 3;
            z = 4;
            bool result = t < z;
            Console.WriteLine(result);
            result = t >= z;
            Console.WriteLine(result);

            result = t <= z;
            Console.WriteLine(result);

            result = t == z;
            Console.WriteLine(result);

            result = t != z;
            Console.WriteLine(result);


            Console.WriteLine("*****Arithmetic*****");

            int num1 = 10;
            int num2 = 5;
            int result1 = num1 / num2;
            Console.WriteLine(result1);
            result1 = num1 * num2;
            Console.WriteLine(result1);


            result1 = num1 + num2;
            Console.WriteLine(result1);


            result1=num1++;
            Console.WriteLine(result1);

            Console.WriteLine("*****Mode*****");
            int result2 = 20 % 3;
            Console.WriteLine(result2);




        }
    }
}
