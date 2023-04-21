using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Leaf:IComponent
    {
        public int size;
        public Leaf(int size)
        {
            this.size = size;
        }

        public int GetSize()
        {
            return size;   
        }
    }
}
