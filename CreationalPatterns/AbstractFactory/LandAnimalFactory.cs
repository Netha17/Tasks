using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class LandAnimalFactory: IFactory
    {
        public IAnimal GetAnimal(string animalType)
        {
            if (animalType == "cat")
                return new Cat();
            else if (animalType == "dog")
                return new Dog();
            else if (animalType == "lion")
                return new Lion();
            else
                return null;
        }
    }
}
