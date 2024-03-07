using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // initializing the rolled numbers so I can make the property
        int rolledNumber1;
        int rolledNumber2;
        int rolledNumber3;
        // <black-eye-inc>
        // Are these parameters supposed to be public or private?
        // The Object-Oriented Principle of "encapsulation" normally wants all parameters in a
        // class to be private.
        // </black-eye-inc>

        /// <summary>
        /// Properity for storing the 1st rolled value
        /// </summary>
        public int RolledNumber1
        {
            get { return rolledNumber1; }
            set { rolledNumber1 = value; }
        }

        /// <summary>
        /// Properity for storing the 2nd rolled value
        /// </summary>
        public int RolledNumber2
        {
            get { return rolledNumber2; }
            set { rolledNumber2 = value; }
        }

        /// <summary>
        /// Properity for storing the 3rd rolled value
        /// </summary>
        public int RolledNumber3
        {
            get { return rolledNumber3; }
            set { rolledNumber3 = value; }
        }
        // <black-eye-inc> Review:
        // the methods "RolledNumber1", "RolledNumber2" and "RolledNumber3" all return an intager,
        // meaning the XML Documentation demands a "<returns>" tag written after their "<summary>"
        // to explain what the methods return.
        // </black-eye-inc>

        /// <summary>
        /// Create 3 dice objects then get the values and add them together
        /// </summary>
        /// <returns>The total of the rolls</returns>
        public int Play()
        {
            // Creating the dice objects in the method because if I don't the propery will stay the same and the continues roll won't work properly
            Die dice1 = new Die();
            // Getting the rolled number by accessing the property
            rolledNumber1 = dice1.Num;
            Console.WriteLine($"You rolled a {rolledNumber1}");
            Die dice2 = new Die();
            rolledNumber2 = dice2.Num;
            Console.WriteLine($"You rolled a {rolledNumber2}");
            Die dice3 = new Die();
            rolledNumber3 = dice3.Num;
            Console.WriteLine($"You rolled a {rolledNumber3}");
            // Getting the total
            int totalNumber = rolledNumber1 + rolledNumber2 + rolledNumber3;
            Console.WriteLine($"The total of your rolls are {totalNumber}");
            // Returning the total number for the testing class
            return totalNumber;
        }

    }
}
