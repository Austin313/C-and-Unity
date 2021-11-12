using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_submission_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Void Void = new Void();
            
            
            Void.Method(1,6);
            Console.ReadLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter in some numbers");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Void.Method(num1, num2);
            Console.ReadLine();

        }
    }
}
