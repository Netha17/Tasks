using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    internal interface IUser
    {
        void sendMessage(Mediator m,string msg);
        void update(string msg,IUser user);
        string getName();


    }
}
