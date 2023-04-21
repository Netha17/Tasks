using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Originator
    {
        private int result;
        public void setResult(int result)
        {
            this.result = result;
        }
        public int getResult()
        {
            return result;
        }
        public Memento CreateMemento()
        {
            return new Memento(result);
        }
        public int getResultFromMemento(Memento memento)
        {
            return memento.getResult();
        }
        
    }
}
