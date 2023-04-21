using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class SeaAnimalFactory: IFactory
    {
        public IAnimal GetAnimal(string animalType)
        {
            if (animalType == "Octopus")
                return new Octopus();
            else if (animalType == "fish")
                return new Fish();
            else
                return null;
        }
    }
}
