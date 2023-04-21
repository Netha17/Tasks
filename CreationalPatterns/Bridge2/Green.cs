using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class Green : IColor
    {
        public void ColorIt(string shape)
        {
            Console.WriteLine("adding green color to"+ shape);
        }
    }
}
