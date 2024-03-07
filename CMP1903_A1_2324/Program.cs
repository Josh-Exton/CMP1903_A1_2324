﻿using System;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        /// <summary>
        /// Main loop of the program
        /// </summary>
        static void Main(string[] args)
        {
            // Creating the game object
            Game game = new Game();
            // Setting a done variable to true can end the while loop
            bool done = false;
            while (!done) 
            {
                // Playing the game by calling the method=
                game.Play();
                // Asking user to play again
                Console.WriteLine("Type \"yes\" if you want to play again");
                // <black-eye-inc> Review:
                // I personally would put "yes" in quotation marks so it is more clear to the user
                // on exactly what you want them to input
                // </black-eye-inc>
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
                Console.WriteLine("");
            }
            // <black-eye-inc>
            // I thought the EXTRA Functionality "Continuous Roll function" was supposed to be a
            // method within the Game class.
            // </black-eye-inc>
            // Finished the loop and displays the message to say that the game is completed 
            Console.WriteLine("Thanks for Playing");
            // // Seperating the games and the testing in the termial
            Console.WriteLine("");
            // Creating the test object
            Testing test = new Testing();
            // Checking the methods in each class
            test.DieCheck();
            test.GameCheck();
            Console.ReadKey();
        }
    }
}
