using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Factory
    {
        public ITransport getInstance(string transportType)
        {
            if(transportType=="ship")
            {
                return new Ship();
            }
            else if(transportType=="Truck")
            {
                return new Truck();
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
