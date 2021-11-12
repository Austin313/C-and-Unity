using System;

namespace Method_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

                Class1 Class = new Class1();

                Console.WriteLine("Please enter some numbers to add");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The next number has a default value of 6, no need to enter anything");
                string num2 = Console.ReadLine();
                bool empty = num2 == "";

            if (empty == true)
                {
                int _num2 = 6;
                Class.Method(num1, _num2);
                Console.ReadLine();
            }
            else
            {
                int _num2 = Convert.ToInt32(num2);
                Class.Method(num1, _num2);
                Console.ReadLine();
            }

                
            

            

        }
    }
}
