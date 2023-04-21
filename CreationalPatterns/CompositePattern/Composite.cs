using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Composite:IComponent
    {
        ArrayList folderList;
        int size;
        public Composite()
        {
            folderList= new ArrayList();
        }
        public void add(IComponent ic)
        {
            folderList.Add(ic);
        }
        public void remove(IComponent ic)
        {
            folderList.Remove(ic);
        }
        public int  getChildren()
        {
            foreach(IComponent ic in folderList)
            {
                size += ic.GetSize();
            }
            return size;
        }
        public int GetSize()
        {
            if(size!=0) return size;
            else
            {
                return getChildren();
            }
            
        }



    }
}
