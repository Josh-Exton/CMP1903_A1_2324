using System;

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
                // <black-eye-inc> Review:
                // I personally would force the user to respond again and again until they give a
                // valid responce and using a wider array of valid potential answers ("yes"/"y" or
                // "no"/"n").
                // So there's plenty of room you could expand this method (potentially by doing
                // what I did and putting it in its own function with exception handling to show
                // off the 'exhaustive exception handing'... although that isn't an OOP principle,
                // so I don't know how many marks it's worth).
                // </black-eye-inc>
                // Seperating the games in the termial
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
            Console.ReadLine();//CHANGED FROM "Console.ReadKey();" to "Console.ReadLine();" -- RESET once done reviewing code!
        }
    }
}
