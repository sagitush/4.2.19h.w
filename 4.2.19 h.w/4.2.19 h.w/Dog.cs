using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._19_h.w
{
    class Dog :Animal
    {
        public string favoriteDogFood;

        public Dog(string favoriteDogFood,string name):base(name)
        {
            this.favoriteDogFood = favoriteDogFood;
        }
        public virtual void Bark()
        {
            Console.WriteLine("woof woof");
        }

        public override void MakeSound()
        {
            Bark();
        }

        public override string ToString()
        {
            return $"Favorite dog food:{favoriteDogFood}+ {base.ToString()}";
        }
    }
}
