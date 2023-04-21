using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Caretaker
    {
        ArrayList mementoList;
        public Caretaker()
        { 
            mementoList=new ArrayList();
        }
        public void AddMemento(Memento m)
        {
            mementoList.Add(m);
        }
        public Memento GetMemento(int index)
        {
            return (Memento)mementoList[index];
        }
        public void GetResult()
        {
            foreach(Memento m in mementoList)
            {
                int res=m.getResult();
                Console.WriteLine(res);
            }
        }
    }
}
