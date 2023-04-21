using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class IDecorator : IPizza
    {
        public virtual string getDesc()
        {
            return "";
        }

        public virtual int getPrice()
        {
            throw new NotImplementedException();
        }
    }
}
