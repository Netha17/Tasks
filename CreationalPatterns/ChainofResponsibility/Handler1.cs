using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    internal class Handler1 : IHandler
    {
        private IHandler _handler;
        public void operation(int difficultyLevel)
        {
            if(difficultyLevel<5)
            {
                Console.WriteLine("this is solved by me");
            }
            else
            {
                _handler.operation(difficultyLevel);
            }
            
        }

        public void setHandler(IHandler h)
        {
            Console.WriteLine(h);
            _handler = h;
            Console.WriteLine(_handler);
        }
    }
}
