using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.CreatingAndUsingObjects
{
    class Cat
    {
        // Field name
        private string name;
        // Field color

        // Default constructor
        public Cat()
        {
            this.name = null;
        }
        // Constructor with parameters
        public Cat(string name)
        {
            this.name = name;
        }
        // Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat{0} said: Miauuuuuu!", name);
        }
    }
}
