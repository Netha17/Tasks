using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class const_readOnly
    {
        const int mtocm = 100;
        readonly double pi;
        public const_readOnly(double pi)
        {
            this.pi = pi;
        }
        public static void Main()
        {
            const_readOnly obj=new const_readOnly(3.14);

        }
    }
}
