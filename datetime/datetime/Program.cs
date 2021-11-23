using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = DateTime.Now;
            Console.WriteLine(time1.ToString());
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            DateTime time2 = time1.AddHours(x);
            Console.WriteLine("Updated time is: " + time2.ToString());
            Console.ReadLine();
        }
            
    }
}
