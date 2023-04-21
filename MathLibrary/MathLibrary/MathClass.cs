using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{/// <summary>
/// Provides methods for arithmetic operations
/// </summary>
    public class MathClass
    {
        /// <summary>
        /// This method is for adding two numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns integer</returns>
        public int add(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// This method is for substraction
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int subtract(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// This method is for multiplication
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Return int</returns>
        /// <exception cref="OverflowException"></exception>
        public int multiply(int x, int y)
        {
            try
            {
                int c=checked(x*y);
                return c;
            }
            catch(OverflowException)
            {
                Console.WriteLine("int maxvalue has been crossed, Please enter less number");
                return -1;
            }
           
        }
        /// <summary>
        /// This method is for division
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public void Division(int x, int y)
        {
            try
            {
                Console.WriteLine(x/y);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divide by zero isn't possible");
                

            }
        }
    }
}
