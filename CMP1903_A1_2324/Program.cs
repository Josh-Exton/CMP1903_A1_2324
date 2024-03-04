using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Game game = new Game();
            bool done = false;
            while (!done) 
            { 
                game.Play();
                Console.WriteLine("Do you want to play again");
                String playAgain = Console.ReadLine();
                playAgain = playAgain.Trim();
                playAgain = playAgain.ToLower();
                if (playAgain != "yes")
                { 
                    done = true;
                }
            }
            Console.WriteLine("Thanks for Playing");
            Testing test = new Testing();
            test.DieCheck();
            test.GameCheck();
            Console.ReadKey();

        }
    }
}
