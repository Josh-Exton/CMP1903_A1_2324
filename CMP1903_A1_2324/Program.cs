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
                Console.WriteLine("Type yes if you want to play again");
                String playAgain = Console.ReadLine();
                // Two methods to help against type errors but doesn't prevent them
                // Gets rid of any white spaces before and after the word
                playAgain = playAgain.Trim();
                // Makes the word all lowercase
                playAgain = playAgain.ToLower();
                // Checking if he wants to play again by typing yes
                if (playAgain != "yes")
                { 
                    // Ending the while loop
                    done = true;
                }
            }
            // Finished the loop and displays the message to say that the game is completed
            Console.WriteLine("Thanks for Playing");
            Testing test = new Testing();
            test.DieCheck();
            test.GameCheck();
            Console.ReadKey();

        }
    }
}
