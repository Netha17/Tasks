using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class BasicOperations
    {
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        private int add(int a,int b)
        {
            return a + b;
        }
        public virtual bool CheckDigitsOnly()
        {
            return false;
        }
    }
}
