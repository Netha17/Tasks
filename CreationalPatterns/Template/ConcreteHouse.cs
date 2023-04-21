using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class ConcreteHouse: Template
    {
       

        public override void buildFoundation()
        {
            Console.WriteLine("Building foundation");
        }

        public override void buildPillars()
        {
            Console.WriteLine("Building concrete pillars");
        }

        public override void buildWalls()
        {
            Console.WriteLine("Building concrete walls");
        }

        public override void buildWindows()
        {
            Console.WriteLine("Building concrete windows");
        }
    }
}
