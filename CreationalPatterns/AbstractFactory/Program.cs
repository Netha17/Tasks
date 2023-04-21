using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = SuperFactory.GetFactory("sea");
            IAnimal animal = factory.GetAnimal("fish");
            Console.WriteLine(animal.speak());
            
            Console.ReadLine();

        }
    }
}
