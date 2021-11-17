using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    class Program
    {
        enum DaysOfTheWeek
        {
            Monday=0,
            Tuesday=1,
            Wendsday=2,
            Thursday=3,
            Friday=4,
            Saturday=5,
            Sunday=6
        }

        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Please select a day of week");
                string day = Console.ReadLine();
                DaysOfTheWeek Week = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine("You have chosen: " + Week);
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
        }
    }
}
