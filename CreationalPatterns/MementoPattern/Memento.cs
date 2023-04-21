using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Memento
    {
        private int result;
        public Memento(int result)
        {
            this.result = result;
        }
        public int getResult()
        {
            return result;
        }
    }
}
