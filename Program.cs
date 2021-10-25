using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            
            Console.WriteLine("What Course are you on");
            string yourCourse = Console.ReadLine();
            
            Console.WriteLine("What page number");
            string pageNumber = Console.ReadLine();
            int PageNumber = Convert.ToInt32(pageNumber);


            Console.WriteLine("Do you need help with anything? Please answer True or False.");
            string needHelp = Console.ReadLine();
            bool helpLogic = Convert.ToBoolean(needHelp);

            Console.WriteLine("Was there any positive experiences you would like to share?");
            string feedback = Console.ReadLine();
           
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string exFeedback = Console.ReadLine();
           
            Console.WriteLine("How many hours did you study?");
            string hours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hours);
            
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
           
            Console.WriteLine("Press enter to close this application..");
           
            Console.ReadLine();
        }
    }
}
