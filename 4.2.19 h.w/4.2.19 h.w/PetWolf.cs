using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._19_h.w
{
    class PetWolf : Wolf
    {
        public PetWolf(string nameOfPack, string name, string favoriteDogFood):base(nameOfPack,name,favoriteDogFood)
        {
                
        }
        public override void Bark()
        {
            Console.WriteLine("");
        }

        public override string ToString()
        {
            return $"Pet wolf {base.ToString()}";
        }
    }
}
