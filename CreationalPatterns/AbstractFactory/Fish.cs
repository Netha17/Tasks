using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Fish : IAnimal
    {
        public string Speak()
        {
            return "can't speak";
        }
    }
}
