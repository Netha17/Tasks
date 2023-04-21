using System;using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace sample
{
    internal class CustomException
    {
        public static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("enter age");
                byte age = Convert.ToByte(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("you are eligible to vote");
                }
                else
                {
                    throw new AgeException("You are not eligible to vote");
                }
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }

        }
    
    public class AgeException : ApplicationException
    {
        public AgeException(string msg):base(msg) { }
        public override string Message => base.Message;
    }
}
