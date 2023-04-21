using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = SuperFactory.GetFactory("honda");
            IBike bike = factory.GetBike("unicorn");
            bike.manufacture();
            Console.ReadLine();
        }
    }
}
