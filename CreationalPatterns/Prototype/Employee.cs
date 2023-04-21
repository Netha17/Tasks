using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Employee
    {
        public int eid;
        public string ename;
        public Employee(int eid,string ename)
        {
           this.eid = eid;
            this.ename= ename;
        }
        public void setName(string name)
            {
            this.ename=name;
        }
        public void setId(int id)
        {
            this.eid = id;
        }
        public void display()
        {
            Console.WriteLine(eid + " " +ename);
        }
        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}
