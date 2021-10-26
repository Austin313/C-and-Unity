using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to Car Solution!");
            string[] cars = { "BMW", "Mercedes", "Audi", "Porsce", "Toyota" };

            Console.WriteLine("Please pick a number between 1 and 5.");
            int Cars = Convert.ToInt32(Console.ReadLine());
            
            switch (Cars)
            {
                case 1:
                    Console.WriteLine(cars[0]);
                    break;
                case 2:
                    Console.WriteLine(cars[1]);
                    break;
                case 3:
                    Console.WriteLine(cars[2]);
                    break;
                case 4:
                    Console.WriteLine(cars[3]);
                    break;
                case 5:
                    Console.WriteLine(cars[4]);
                    break;
                default:
                    Console.WriteLine("that is not a valid selection, please restart the program to try again");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

            }

            Console.WriteLine("Nice choice!, Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Okay now pick again a number between 1 - 5.");
            int[] carsYear = { 2020, 2019, 2018, 2017, 1990 };
            int CarsYear = Convert.ToInt32(Console.ReadLine());
            
            switch (CarsYear)
            {
                case 1:
                    Console.WriteLine(carsYear[0]);
                    break;
                case 2:
                    Console.WriteLine(carsYear[1]);
                    break;
                case 3:
                    Console.WriteLine(carsYear[2]);
                    break;
                case 4:
                    Console.WriteLine(carsYear[3]);
                    break;
                case 5:
                    Console.WriteLine(carsYear[4]);
                    break;

                default:
                    Console.WriteLine("that is not a valid selection, please restart the program to try again");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;

            }
            Console.WriteLine("Wow another good choice!, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Here are some car company founders!, select their number and learn a little fact about them!");
            
            List<string> people = new List<string>();
            people.Add("1.August Horch ");
            people.Add("2.Karl Rapp ");
            people.Add("3.Karl Benz ");
            people.Add("4.Ferdinand Porsche ");
            people.Add("5.KiiChiro Toyoda ");
            Console.WriteLine(people[0]);
            Console.WriteLine(people[1]);
            Console.WriteLine(people[2]);
            Console.WriteLine(people[3]);
            Console.WriteLine(people[4]);
            int People = Convert.ToInt32(Console.ReadLine());

            switch (People)
            {
                case 1:
                    Console.WriteLine("///////////////////////////////");
                    Console.WriteLine(people[0]);
                    Console.WriteLine("August was a German engineer and automobile pioneer, the founder of the manufacturing giant which would eventually become Audi.");
                    break;
                case 2:
                    Console.WriteLine("///////////////////////////////");
                    Console.WriteLine(people[1]);
                    Console.WriteLine("Karl Rapp was a German founder and owner of the Rapp Motorenwerke GmbH in Munich. In time this company became BMW AG. He is acknowledged by BMW AG as an indirect founder of the company.");
                    break;
                case 3:
                    Console.WriteLine("///////////////////////////////");
                    Console.WriteLine(people[2]);
                    Console.WriteLine("Karl Benz was a German engine designer and automotive engineer. His Benz Patent Motorcar from 1885 is considered the first practical automobile put into series production. He received a patent for the motorcar in 1886.");
                    break;
                case 4:
                    Console.WriteLine("///////////////////////////////");
                    Console.WriteLine(people[3]);
                    Console.WriteLine("Ferdinand was a German automotive engineer and founder of the Porsche car company. Also know for making the VW Beetle!");
                    break;
                case 5:
                    Console.WriteLine("///////////////////////////////");
                    Console.WriteLine(people[4]);
                    Console.WriteLine("Kiichiro was a Japanese businessman and the son of Toyoda Loom Works founder Sakichi Toyoda. His decision to change Toyoda's focus from automatic loom manufacture into automobile manufacturing created what would become Toyota Motor Corporation.");
                    break;
            }

            Console.WriteLine("///////////////////////////////");
            Console.WriteLine("Thanks for using this program! please press enter to exit.");
            Console.ReadLine();


        }
    }
}
