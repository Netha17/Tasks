using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    internal interface IHandler
    {
        void setHandler(IHandler h);
        void operation(int difficultyLevel );
    }
}
