using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class Red : IColor
    {
        public void ColorIt(string shape)
        {
            Console.WriteLine("adding red color"+ shape);
        }
    }
}
