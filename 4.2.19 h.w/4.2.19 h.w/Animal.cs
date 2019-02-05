using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._19_h.w
{
    abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }
        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Animal name:{name}";
        }
    }
}
