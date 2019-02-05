using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._19_h.w
{
    class Wolf:Dog
    {
        public string nameOfPack;

        public Wolf(string nameOfPack,string name,string favoriteDogFood):base(favoriteDogFood,name)
        {
            this.nameOfPack = nameOfPack;
        }

        public override string ToString()
        {
            return $"Wolf {base.ToString()},Name of pack{nameOfPack}";
        }
    }
}
