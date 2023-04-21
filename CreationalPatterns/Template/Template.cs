using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal abstract class Template
    {
        public abstract void buildFoundation();
        public abstract void buildPillars();
        public abstract void buildWalls();
        public abstract void buildWindows();
        public void BuildHouse()
        {
            buildFoundation();
            buildPillars();
                
            buildWalls();
            buildWindows();
        }

    }
}
