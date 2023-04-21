using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLibrary
{
    public class Service:MarshalByRefObject
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
