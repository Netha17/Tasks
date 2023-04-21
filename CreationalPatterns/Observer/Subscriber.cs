using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subscriber:ISubscriber
    {
        public string name;
        public Subscriber(string name)
        {
            this.name = name;
        }
        public void update(string product)
        {
            Console.WriteLine("Hey"+name+"The product "+product+"is availabe");
        }
    }
}
