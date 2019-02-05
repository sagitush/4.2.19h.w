using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._19_h.w
{
    class Horse: Animal
    {
        public bool racingHorse;

        public Horse(bool racingHorse,string name):base(name)
        {
            this.racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("e e e");
        }

        public override string ToString()
        {
            return $"This is a racing horse:{racingHorse}+ {base.ToString()}";
        }
    }
}
