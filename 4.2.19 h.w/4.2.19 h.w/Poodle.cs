using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._19_h.w
{
    class Poodle:Dog
    {
        public string numberOfPonyTails;

        public Poodle(string numberOfPonyTails,string name,string favoriteDogFood):base(favoriteDogFood,name)
        {
            this.numberOfPonyTails = numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("av av");
        }

        public override string ToString()
        {
            return $"Poodle{base.ToString()},Number of ponytails{numberOfPonyTails}";
        }
    }
}
