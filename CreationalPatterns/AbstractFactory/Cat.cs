using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Cat : IAnimal
    {
        public string Speak()
        {
            return "meow";
        }
    }
}
