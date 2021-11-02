using System;
using System.Collections.Generic;


namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part 1
            string[] Students = { "Austin ", "Devin ", "Justin ", "Nancy " };
            string message = Console.ReadLine();
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(Students[i] + message);
            }
            Console.ReadLine();


            

            //int[] infiniteLoop = { 1, 3, 5, 6, 7 };
            ////Part 2
            ////Changing the for statement with i-- would cause the program to continue infinitly into negatives and never reach the value of 5
            //for (int i = 0; i < infiniteLoop.Length; i++)
            //{
            //    Console.WriteLine(infiniteLoop[i]);
            //}
            //Console.WriteLine("Wow nice numbers!");
            //int[] damage = { 2, 10, 5, 7, 2 };
            ////Part 3
            //for (int i = 0; i <= damage.Length; i++)
            //{
            //    if (i == 1)
            //    {
            //        int crit = damage[i] * 2;
            //        Console.WriteLine(crit);
            //        Console.WriteLine("Critical Strike!");
            //    }

            // }
            //part 4
            //Console.WriteLine("Search a student first name to see their information, or type exit to leave the program");
            //List<string> Students = new List<string>();
            //    Students.Add("Nancy");
            //    Students.Add("Austin");
            //    Students.Add("Rosa");
            //    Students.Add("Hank");
            //string search = Console.ReadLine();
            //bool isPresent = Students.Contains(search);
            //if (isPresent == true)
            //{
            //    int index = Students.FindIndex(x => x.Contains(search));
            //    Console.WriteLine(index);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry your input is not valid");
            //}

            //part 5
            //Console.WriteLine("Search for a produce item");
            //List<string> produce = new List<string>();
            //produce.Add("Orange");
            //produce.Add("Grape");
            //produce.Add("Orange");
            //produce.Add("Apple");
            //produce.Add("Cherry");
            //string item = Console.ReadLine();
            //for (int i = 0; i <= (produce.Count - 1); i++)
            //{
            //    if (produce[i] == item)
            //    {
            //        Console.WriteLine("Item found!: " + i);

            //    }
            //    else
            //    {
            //        Console.WriteLine("This item is not on the list");
            //    }

            //}
            //List<string> meat = new List<string>();
            //meat.Add("beef");
            //meat.Add("chicken");
            //meat.Add("beef");
            //meat.Add("Pork");
            //List<string> search = new List<string>();
            //foreach (string x in meat)
            //{
            //    if (search.Contains(x)) 
            //    {
            //        Console.WriteLine("This has been added");
            //    }
            //    else
            //    {
            //        Console.WriteLine("this item has not been added");
            //    }
            //    search.Add(x);
            //    Console.WriteLine(x);
            //}
            Console.ReadLine();
        }
    }
}





        
            
                
                

            

            
        
    

