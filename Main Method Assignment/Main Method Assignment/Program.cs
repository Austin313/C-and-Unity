using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer1 integer = new Integer1();

            Console.WriteLine("Lets Add!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            integer.Method1(num1,num2);

            Console.WriteLine("==============================");

            Console.WriteLine("Multiply two decimals together");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            decimal num4 = Convert.ToDecimal(Console.ReadLine());
            integer.Method2(num3, num4);

            Console.WriteLine("==============================");

            Console.WriteLine("Enter a number");
            int Number = Convert.ToInt32(Console.ReadLine());
            integer.Method3(Number);

            Console.WriteLine("=================================");

            Console.ReadLine();

        }
   
    }
}
