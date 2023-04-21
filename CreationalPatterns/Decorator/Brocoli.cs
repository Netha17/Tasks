using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Brocoli: IDecorator
    {
       private IPizza _pizza;
       public Brocoli(IPizza pizza)
        {
            _pizza = pizza;
        }
        public override string getDesc()
        {
            return _pizza.getDesc() + "brocoli added";
        }
        public override int getPrice()
        {
            return _pizza.getPrice() + 50;
        }
        

    }
}
