using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqDemo
{
    public class Class1
    {
        
        public void method1()
        {
            string n = "nithin";
            var msg = n.hello();
        }
    }
    public static class StringHelper
    {
        public static string  hello(this string  s)
        {
            return "hello " + s;
        }
    }
}