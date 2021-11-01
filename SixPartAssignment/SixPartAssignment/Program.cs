using System;
using System.Collections.Generic;


namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            List<string> names = new List<string>() { "Austin", "Devin", "Justin", "Nancy" };
            
            
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Please add your name to this list!");
            string name = Console.ReadLine();
            names.Add(name);
            Console.WriteLine("Thanks, " + name);
            Console.WriteLine("/////////////////////////////////////////");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            int[] infiniteLoop = { 1, 3, 5, 6, 7 };
            //Part 2
            //Changing the for statement with i-- would cause the program to continue infinitly into negatives and never reach the value of 5
            for (int i = 0; i < infiniteLoop.Length; i++)
            {
                Console.WriteLine(infiniteLoop[i]);
            }
            Console.WriteLine("Wow nice numbers!");
            int[] damage = { 2, 10, 5, 7, 2 };
            //Part 3
            for (int i = 0; i <= damage.Length; i++)
            {
                if (i == 1)
                {
                    int crit = damage[i] * 2;
                    Console.WriteLine(crit);
                    Console.WriteLine("Critical Strike!");
                }
                   
             }
            //part 4
            Console.WriteLine("Search a student first name to see their information, or type exit to leave the program");
            List<string> Students = new List<string>();
                Students.Add("Nancy");
                Students.Add("Austin");
                Students.Add("Rosa");
                Students.Add("Hank");
            string search = Convert.ToString(Console.ReadLine());
            bool exit = false;

            do
            {
                switch (search)
                {
                    case "Nancy":
                        Console.WriteLine(Students[0]);
                        Console.WriteLine("PhoneNum:555-555-1313 Email: NancyN@email.com");
                        search = Convert.ToString(Console.ReadLine());
                        break;
                    case "Austin":
                        Console.WriteLine(Students[1]);
                        Console.WriteLine("PhoneNum:555-555-1335 Email: AustinN@email.com");
                        search = Convert.ToString(Console.ReadLine());
                        break;
                    case "Rosa":
                        Console.WriteLine(Students[2]);
                        Console.WriteLine("PhoneNum:555-555-1374 Email: RosaN@email.com");
                        search = Convert.ToString(Console.ReadLine());
                        break;
                    case "Hank":
                        Console.WriteLine(Students[3]);
                        Console.WriteLine("PhoneNum:555-555-1265 Email: HankN@email.com");
                        search = Convert.ToString(Console.ReadLine());
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("That is not a valid entry, try again");
                        search = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!exit);
            //part 5
            Console.WriteLine("Search for a produce item");
            List<string> produce = new List<string>();
            produce.Add("Orange");
            produce.Add("Grape");
            produce.Add("Orange");
            produce.Add("Apple");
            produce.Add("Cherry");
            Console.WriteLine(produce[0]);
            Console.WriteLine(produce[1]);
            Console.WriteLine(produce[2]);
            Console.WriteLine(produce[3]);
            Console.WriteLine(produce[4]);
            foreach (string fruits in produce)
            {
                

                if (fruits.Contains("Orange"))
                {
                    string fruit = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(fruit);
                }
            }
            //part 6
            List<string> meat = new List<string>();
            meat.Add("beef");
            meat.Add("Chicken");
            meat.Add("beef");
            meat.Add("pork");
            foreach (string duplicate in meat)
            {
                
                if (meat.Contains(duplicate))
                {
                    string selection = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(selection);
                    Console.WriteLine("This item is already added!");



                }
                else
                {
                    Console.WriteLine("Item will be added!");
                    meat.Add(duplicate);
                }

            }

            Console.ReadLine();
        }
    }
}
