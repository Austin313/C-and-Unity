using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment
{
    public class Class1
    {
        public void Method(int num1, int num2 = 6)
        {                             
            int result = num1 + num2;
            Console.WriteLine(result);
            return;
        }
    }
}
