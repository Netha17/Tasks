using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    internal class Context
    {
        private IStrategy _strat;
        public Context(IStrategy strategy  ) {
            _strat = strategy;
        }
        public void makeOperation(int a,int b)
        {
            _strat.doOperation(a,b);

        }
    }
}
