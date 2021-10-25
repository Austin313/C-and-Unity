using System;

namespace while_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is 4+4?");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool isGuessing = answer == 8;
            
   
            while (!isGuessing)
            { 
                switch (answer)
                {
                    case 8:
                        Console.WriteLine("That answer is correct!");
                        isGuessing = true;
                        break;

                    default:
                        Console.WriteLine("That is incorrect, try again.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;

                }    

            }

            Console.WriteLine("What is 5+6?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            bool isGuessing2 = answer2 == 11;

            do
            {
                switch (answer2)
                {
                    case 11:
                        Console.WriteLine("That answer is correct!");
                        isGuessing2 = true;
                        break;

                    default:
                        Console.WriteLine("That is incorrect, try again.");
                        answer2 = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessing2);
            

            Console.ReadLine();

        }
    }
}
