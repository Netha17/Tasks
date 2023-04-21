using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class WoodenHouse : Template
    {
        public override void buildFoundation()
        {
            Console.WriteLine("Building foundation ");
        }

        public override void buildPillars()
        {
            Console.WriteLine("build pillars");
        }

        public override void buildWalls()
        {
            Console.WriteLine("build wooden walls");
        }

        public override void buildWindows()
        {
            Console.WriteLine("build wooden pillars");
        }
    }
}
