using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            employee.IsQuitting = true;
            employee.Quit();
            Console.ReadLine();
        }
    }
}
