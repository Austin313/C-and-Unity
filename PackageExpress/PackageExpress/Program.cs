using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please Follow the instructions below.");
            Console.WriteLine("Please enter the Package Weight");
            string weightString = Console.ReadLine();
            int Weight = Convert.ToInt32(weightString);
            if (Weight > 50)
            {
                Console.WriteLine("This package is too heavy. Please reduce the weight.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Thanks, please enter the dimensions now.");
            }

            Console.WriteLine("Please enter the Package width:");
            string widthString = Console.ReadLine();
            int Width = Convert.ToInt32(widthString);


            Console.WriteLine("Please enter the Package height:");
            string heightString = Console.ReadLine();
            int Height = Convert.ToInt32(heightString);

            Console.WriteLine("Please enter the Package length:");
            string LengthString = Console.ReadLine();
            int Length = Convert.ToInt32(LengthString);

            if (Width + Height + Length > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            int dimensionProd = Width * Length * Height;
            int totalCost = dimensionProd * Weight / 100;

            Console.WriteLine("Thank you, your qoute is costed at: $" + totalCost);
            Console.WriteLine("Press enter to close this program...");
            Console.ReadLine();
        }
    }
}
