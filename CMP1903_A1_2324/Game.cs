using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        // Creating the dice objects
        Die dice1 = new Die();
        Die dice2 = new Die();
        Die dice3 = new Die();

        int rolledNumber1;
        int rolledNumber2;
        int rolledNumber3;

        public int RolledNumber1
        {
            get { return rolledNumber1; }
            set { rolledNumber1 = value; }
        }
        public int RolledNumber2
        {
            get { return rolledNumber2; }
            set { rolledNumber2 = value; }
        }
        public int RolledNumber3
        {
            get { return rolledNumber3; }
            set { rolledNumber3 = value; }
        }

        //Methods
        public int Play()
        {
            rolledNumber1 = dice1.Roll();
            Console.WriteLine($"You rolled a {rolledNumber1}");
            rolledNumber2 = dice2.Roll();
            Console.WriteLine($"You rolled a {rolledNumber2}");
            rolledNumber3 = dice3.Roll();
            Console.WriteLine($"You rolled a {rolledNumber3}");
            int totalNumber = rolledNumber1 + rolledNumber2 + rolledNumber3;
            Console.WriteLine($"The total of your rolls are {totalNumber}");
            return totalNumber;
        }

    }
}
