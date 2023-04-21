using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e=new Employee("Nithin");
            Mediator mediator = new Mediator();
            mediator.resign(e);
            Console.ReadLine();
        }
    }
}
