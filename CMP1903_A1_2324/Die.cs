using System;
using System.Threading;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Creating the random field
        Random rand;
        // Creating the number field
        private int _num;
        // <black-eye-inc>
        // XML Documentation says to use "<value>" tags before a parameter like "_num" to explain
        // what it is and what it does.
        // </black-eye-inc>

        /// <summary>
        /// The number properity which will be between 1 and 6
        /// </summary>
        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }
        // <black-eye-inc> Review:
        // You could add error checking that makes sure the value input into "_num" is between
        // 1 and 6 -- that'd definately be worth some marks

        // Also I couldn't find any "<returns>" XML Documentation
        // </black-eye-inc>

        /// <summary>
        /// Constructer which will initize random and set the number field
        /// </summary>
        public Die()
        {
            // initizling the random 
            rand = new Random();
            _num = Roll();
        }

        /// <summary>
        /// Gets a value 1 to 6 
        /// </summary>
        /// <returns>A value from 1 to 6</returns>
        public int Roll()
        {
            // Need the program to wait otherwise it returns the same value
            Thread.Sleep(5);
            // Asaigns a random number between 1 and 6
            int num = rand.Next(1,7);
            return num;
        }

    }
}
