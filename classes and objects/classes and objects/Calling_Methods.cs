using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class Calling_Methods
    {
        public static void method1()
        {
            Console.WriteLine("Lets Multiply!");
            int op1 = Convert.ToInt32(Console.ReadLine());
            int op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(op1 * op2);
            
        }
        public static void method2()
        {
            Console.WriteLine("Lets Divide!");
            int op1 = Convert.ToInt32(Console.ReadLine());
            int op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(op1 / op2);
            
        }
        public static void method3()
        {
            Console.WriteLine("Lets Add!");
            int op1 = Convert.ToInt32(Console.ReadLine());
            int op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(op1 + op2);
        }

    }
}
