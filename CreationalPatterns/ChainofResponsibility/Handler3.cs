using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    internal class Handler3:IHandler
    {
        private IHandler _handler;
        public void operation(int difficultyLevel)
        {
            if (difficultyLevel <= 10)
            {
                Console.WriteLine("this is solved by Ravi");
            }
            else
            {
                Console.WriteLine("this question remain unsolved");
            }

        }

        public void setHandler(IHandler h)
        {
            _handler = h;
            Console.WriteLine(_handler);
        }
    }
}
