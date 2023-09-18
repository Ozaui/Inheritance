using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string animalName;
        public string animalRace;
        public string animalColour;

        public void ShowAnimalInformation()
        {
            Console.WriteLine("Animal name = " +  animalName);
            Console.WriteLine("Animal race = " + animalRace);
            Console.WriteLine("Animal colour = " + animalColour);
        }
    }
}
