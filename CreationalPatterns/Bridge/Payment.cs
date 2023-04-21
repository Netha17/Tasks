using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class Payment
    {
      static public IPayment payment;
        public abstract void MakePayment();
    }
}
