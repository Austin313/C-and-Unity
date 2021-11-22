using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {FName = "Stewart", LName = "Reynalds", ID = 1 },
                new Employee {FName = "Joe", LName = "Muniz", ID = 2 },
                new Employee {FName = "Frank", LName = "Bard", ID = 3 },
                new Employee {FName = "Mark", LName = "Jacobs", ID = 4 },
                new Employee {FName = "Susan", LName = "Jones", ID = 5 },
                new Employee {FName = "Joe", LName = "Logan", ID = 6 },
                new Employee {FName = "Austin", LName = "Hamilton", ID = 7 },
                new Employee {FName = "Justin", LName = "Neron", ID = 8 },
                new Employee {FName = "Devin", LName = "Gilson", ID = 9 },
                new Employee {FName = "Hannah", LName = "Baker", ID = 10 }
            };
            List<Employee> joeList = new List<Employee>();
            
            
            var names = employees.Select(x => x.FName);
            foreach (Employee emp in employees)
            {
                if (emp.FName == "Joe" )
                {
                    Console.WriteLine(emp.FName);
                    joeList.Add(emp);
                    Console.WriteLine("This has been added to the list.");
                }
            }
            List<Employee> joeList2 = employees.Where(x => x.FName == "Joe").ToList();
            List<Employee> ID = employees.Where(x => x.ID >= 5).ToList();
            foreach (Employee emp in employees)
            {
                if(emp.ID >= 5)
                {
                    Console.WriteLine(emp.FName + " " + emp.LName);
                }
            }
            Console.ReadLine();
        }
    }
}
