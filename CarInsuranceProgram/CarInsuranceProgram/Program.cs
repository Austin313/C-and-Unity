using System;


namespace CarInsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int Age = Convert.ToInt32(ageString);

            Console.WriteLine("Have you ever had a DUI? Please enter True or False");
            string DUIstring = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIstring);

            Console.WriteLine("How many speeding tickets do you have?");
            string speedString = Console.ReadLine();
            int Speed = Convert.ToInt32(speedString);

            Console.WriteLine("Qualified");
            if (Age >= 15 && DUI == false && Speed <= 3 )
            {
                Console.WriteLine("Congratulations! You've qualified for *** insurance!");
            }
            else
            {
                Console.WriteLine("Sorry, but you do not qualify.");
            }
            Console.WriteLine("Press enter to exit application");
            Console.ReadLine();
        }
    }
}
