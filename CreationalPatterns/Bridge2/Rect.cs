using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class Rect : IShape2
    {
        public override void drawShape()
        {
            col.ColorIt("Rectangle");
        }
    }
}
