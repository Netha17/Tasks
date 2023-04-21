using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adaptee
    {
        public void chargeMobile(Volt v)
        {
            int currentVolt=v.getVolt();
            if (currentVolt==3) {
                Console.WriteLine("Mobile is charging using " + v.getVolt()+" volts");
            }
            else
            {
                Console.WriteLine("Mobile will not charge");
            }
           
        }
    }
}
