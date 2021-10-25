using System;

namespace while_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the capital of Texas?");
            string answer = Console.ReadLine();
            bool isGuessing = answer == "Austin";
   
            while (!isGuessing)
            {
                switch (answer)
                {
                    case "Austin":
                        Console.WriteLine("That answer is correct!");
                        break;

                    default:
                        Console.WriteLine("That is incorrect, try again.");
                        break;

                }    

            }
            //lol is this cheating 
            Console.WriteLine("That is correct!");
            Console.ReadLine();

        }
    }
}
