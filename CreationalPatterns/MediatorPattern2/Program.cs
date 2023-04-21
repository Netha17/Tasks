using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User1 nithin = new User1("nithin");
            User2 Kamala = new User2("kaamala");
            User2 rahul = new User2("rahul");
            User2 sandy = new User2("sandy");
            Mediator mediator= new Mediator();
            mediator.Register(nithin);
            mediator.Register(Kamala);
            mediator.Register(rahul);
            mediator.Register(sandy);
            nithin.sendMessage(mediator,"Hi kamala,When shall we meet and patch up?");
            Kamala.sendMessage(mediator, "I will not patch up with you nithin");
            Console.ReadLine();
        }
    }
}
