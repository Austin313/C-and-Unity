using System;


namespace MathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourlyRate1 = 15;
            int hourlyRate2 = 20;
            int hoursWorked = 40;
            int salary1 = hourlyRate1 * hoursWorked * 52;
            int salary2 = hourlyRate2 * hoursWorked * 52;
            bool compare = salary1 > salary2;
            
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Wage?");
            Console.WriteLine(hourlyRate1);
            Console.WriteLine("hours worked?");
            Console.WriteLine(hoursWorked);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Wage?");
            Console.WriteLine(hourlyRate2);
            Console.WriteLine("hours worked");
            Console.WriteLine(hoursWorked);
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(compare);
            Console.ReadLine();
        }
    }
}
