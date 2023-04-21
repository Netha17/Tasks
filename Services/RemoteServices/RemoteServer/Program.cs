using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemoteServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(8085);
            ChannelServices.RegisterChannel(ch);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof
                           (RemoteLibrary.Service), "rahul", WellKnownObjectMode.Singleton);
            Console.Write("Sever is  Ready........");
            Console.Read();
        }
    }
}
