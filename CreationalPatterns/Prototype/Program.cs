using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "Nithin");
            //Console.WriteLine(e.ename);
            e.display();
           Employee cloned_emp=e.GetClone();
            cloned_emp.setName("kamala");
            cloned_emp.setId(5);
            cloned_emp.display();
            
          
            Console.ReadLine();

        }
    }
}
