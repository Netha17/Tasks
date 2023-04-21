using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    internal class Handler2: IHandler
    {
        private IHandler _handler;
        public void operation(int difficultyLevel)
        {
            if (difficultyLevel < 7)
            {
                Console.WriteLine("this is solved by Harish");
            }
            else
            {
                _handler.operation(difficultyLevel);
            }

        }

        public void setHandler(IHandler h)
        {
            _handler = h;
            Console.WriteLine(_handler);
        }
    }
}
