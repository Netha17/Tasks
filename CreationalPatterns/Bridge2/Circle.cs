using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class Circle : IShape2
    {
        public override void drawShape()
        {
            Console.WriteLine("drawing circle shape");
            col.ColorIt("circle");
        }
    }
}
