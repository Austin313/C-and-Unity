using System;
using System.Collections.Generic;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            employee.IsQuitting = true;
            employee.Quit();
            Console.ReadLine();
            Employee<string> employee1 = new Employee<string>();
            employee1.things = new List<string>();
            employee1.things.Add("Desk");
            employee1.things.Add("Chair");
            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int>();
            employee2.things.Add(3);
            employee2.things.Add(1);

            int i = 0;
            for (i = 0; i <= 1; i++)
            {
                Console.WriteLine(employee1.things[i]);
                Console.WriteLine(employee2.things[i]);
            }
            Console.ReadLine();
        }
    }
}
