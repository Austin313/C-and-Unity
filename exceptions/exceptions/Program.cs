using System;
using System.Collections.Generic;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    console.writeline("pick a number");
            //    int numberone = convert.toint32(console.readline());
            //    console.writeline("pick a second number");
            //    int numbertwo = convert.toint32(console.readline());
            //    console.writeline("divide the two");
            //    int numberthree = numberone / numbertwo;
            //    console.writeline(numberone + " divided by " + numbertwo + " equals " + numberthree);
            //    console.readline();
            //}
            //catch (formatexception ex)
            //{
            //    console.writeline(ex.message);
            //    return;
            //}
            //catch (dividebyzeroexception ex)
            //{
            //    console.writeline("please dont divide by zero");
            //}
            //catch (exception ex)
            //{
            //    console.writeline(ex.message);
            //}
            //finally
            //{
            //    console.readline();
            //}
            try
            {
                List<int> num = new List<int>();
                num.Add(7);
                num.Add(3);
                num.Add(42);
                int input = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Enter a number to divide in the list");
                    Console.WriteLine(num[i]);
                    int divide = num[i] / input;
                    Console.WriteLine(num[i] + " divided by " + input + " equals " + divide);
                }      
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();

          
        }
    }
}
