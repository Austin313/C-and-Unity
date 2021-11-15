using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ex = new Class1();

            Console.WriteLine("Lets divide a number by 2, please enter any number.");
            int num = Convert.ToInt32(Console.ReadLine());
            ex.Method(num);
            Console.ReadLine();
        }
    }
}
