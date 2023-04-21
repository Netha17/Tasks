using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Subscriber2:ISubscriber
    {
        public string name;
        public Subscriber2(string name)
        {
            this.name = name;
        }
        public void update(string product, string publisher)
        {
            Console.WriteLine("Hey " + name + " The " + product + " is availabe in " + publisher);
        }

    }
}
