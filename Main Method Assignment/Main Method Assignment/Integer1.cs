using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Integer1
    {
        public static void Method1()
        {
            Console.WriteLine("Lets Add!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num2 + num1;
            Console.WriteLine(result);
        }
        public static void Method2()
        {
            Console.WriteLine("Multiply two decimals together");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 * num2;
            Console.WriteLine(result);
        }
        public static void Method3()
        {
            Console.WriteLine("Enter a number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int result = Number * 6;
            Console.WriteLine(Number + " Times 6 equals " + result);
        }
    }
}
