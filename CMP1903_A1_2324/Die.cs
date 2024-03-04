using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        //Method
        
        Random rand;
        private int _num;
        public Die()
        { 
            rand = new Random();
            _num = Roll();
        }

        public int Num // Property
        {
            get { return _num; } // Get method
            set { _num = value; } // Set method
        }

        public int Roll()
        { 
            int num = rand.Next(1,7);
            return num;
        }

    }
}
