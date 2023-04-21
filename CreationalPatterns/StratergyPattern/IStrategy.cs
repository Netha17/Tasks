using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    internal interface IStrategy
    {
        void doOperation(int a,int b);
    }
}
