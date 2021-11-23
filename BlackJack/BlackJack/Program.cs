using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = new DateTime(2001,6,23);
            Console.WriteLine("Welcome to the Grand Hotel Casino. Lets start by telling me your name.");
            string name = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a table for a game of BlackJack?", name);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(name, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");

            }
            Console.WriteLine("Feel free to look around the casino");
            Console.Read();

        }
    }
}
