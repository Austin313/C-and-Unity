using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Integer1
    {
        public int Method(int num1, int num2)
        {
            
            int result = num2 + num1;
            Console.WriteLine(result);
            return result;
        }
        public int Method(decimal num1, decimal num2)
        {
            int result = Convert.ToInt32(num1 * num2);
            Console.WriteLine(result);
            return result;
        }
        public int Method(string Number)
        {

            int _number = Convert.ToInt32(Number);
            int result = Convert.ToInt32(_number * 6);
            Console.WriteLine(Number + " times 6 equals " + result);
            return result;
        }
    }
}
