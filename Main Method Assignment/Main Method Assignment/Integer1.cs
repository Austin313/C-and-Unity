using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Integer1
    {
        public int Method1(int num1, int num2)
        {
            
            int result = num2 + num1;
            Console.WriteLine(result);
            return result;
        }
        public int Method2(decimal num1, decimal num2)
        {
            int result = Convert.ToInt32(num1 * num2);
            Console.WriteLine(result);
            return result;
        }
        public int Method3(int Number)
        {           
            int result = Number * 6;
            Console.WriteLine(Number + " times 6 equals " + result);
            return result;
        }
    }
}
