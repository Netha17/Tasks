using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Volt v = new Volt(240);
            Adapter adapter= new Adapter();
            adapter.chargeTheDevice(v);
            Console.ReadLine();
        }
    }
}
