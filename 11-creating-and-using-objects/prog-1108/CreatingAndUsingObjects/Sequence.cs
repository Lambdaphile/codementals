using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.CreatingAndUsingObjects
{
    class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;
        // Intentionally deny instantiation of this class
        private Sequence()
        {
        }
        // Static method for taking the next sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
