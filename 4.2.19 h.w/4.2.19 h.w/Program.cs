using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._19_h.w
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog popsy = new Dog("bonzo", "popsy");
            Horse[] horses = {
            new Horse(true, "goren"),
             new Horse(false, "miki"),
             new Horse(true, "moni"),
             new Horse(false, "gor"),
            new Horse(true, "vor"),
             new Horse(true, "mor") };
            Poodle doli = new Poodle("big", "doli", "bonzo");
            Wolf wolf = new Wolf("lopus", "wolf", "meat");
            PetWolf pet = new PetWolf("lopus", "pet", "milk");
            Horse[] racinghorses;
            GetRacingHorses(horses,out racinghorses);
            for (int i = 0; i < racinghorses.Length; i++)
            {
                Console.WriteLine(racinghorses[i]);
            }
            Animal[] animals =
            { new Dog("bonzo", "popsy"),new Horse(true, "goren"),new Poodle("big", "doli", "bonzo"),
            new Wolf("lopus", "wolf", "meat"),new PetWolf("lopus", "pet", "milk")

            };
            AnimalSing(animals);
        }
        static void AnimalSing(Animal[] animals)
        {
            for (int i = 0; i <animals.Length; i++)
            {
                animals[i].MakeSound();
            }
        }
        static void  GetRacingHorses(Horse[]horses,out Horse[] racinghorses)
        {
            int sum = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].racingHorse == true)
                {
                    sum = sum + 1;
                }
            }
            racinghorses = new Horse[sum];
            int sum2 = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].racingHorse==true)
                {
                    racinghorses[sum2] = horses[i];
                    sum2 = sum2 + 1;
                }
            }
            
        }
    }
}
