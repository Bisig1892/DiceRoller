using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Represents an individual dice
    /// </summary>
    class Die
    {
        // Static fields are shared across all instances of a class
        static Random rand;

        // Static constructors are called once for all instances of the class
        static Die()
        {
            rand = new Random();
        }

        public Die()
        {
            Roll(); // Roll die on creation to generate first random number
        }

        /// <summary>
        /// Face value of die
        /// </summary>
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Roll a new random value between 1-6 and return the newly rolled value
        /// If the die is held, the current value will be returned and no new value generated
        /// </summary>
        public byte Roll()
        {
            if (!IsHeld)
            {
                Value = (byte)rand.Next(1, 7);
            }
            return Value;
        }
    }
}
