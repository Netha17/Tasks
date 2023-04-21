using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal abstract class IShape2
    {
        public IColor col;
         abstract  public void  drawShape();
    }
}
