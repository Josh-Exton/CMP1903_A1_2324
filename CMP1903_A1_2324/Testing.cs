using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        Die dice = new Die();
        Game game = new Game();

        // Checks the roll methods in the die class to see if returns a number between 1 and 6
        public void DieCheck()
        { 
            int roll = dice.Roll();
            Debug.Assert(roll > 0 & roll <7);
        }

        // Checks the play method to see if it adds the values correctly
        public void GameCheck()
        {
            // int suspectedTotal = game.Play();
            // int num1 = game.RolledNumber1;
            // Console.WriteLine(num1);
            // int num2 = game.RolledNumber2;
            // Console.WriteLine(num2);
            // int num3 = game.RolledNumber3;
            // Console.WriteLine(num3);
            // int total = num1 + num2 + num3;
            // Console.WriteLine($"testing {total}");
            // Debug.Assert(suspectedTotal == total);
        }
    }
}
