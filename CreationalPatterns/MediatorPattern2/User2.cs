using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    internal class User2:IUser
    {
        private string _name;
        public User2(string name)
        {
            _name = name;
        }
        public void sendMessage(Mediator m,string msg)
        {
            m.showMessage(msg, this);
        }
        public string getName() {
            return _name;
        }
        public void update(string msg,IUser i)
        {
            Console.WriteLine(_name+":"+msg +"This msg has been sent by "+i.getName());
        }
    }
}
