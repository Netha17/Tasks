using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    internal class User1:IUser
    {
        private string _name;
        public User1(string name)
        {
            _name = name;
        }
        public string getName()
        {
            return _name;
        }
        public void sendMessage(Mediator m,string msg)
        {
            m.showMessage(msg, this);
        }
        public void update(string msg,IUser user)
        {
            Console.WriteLine(_name + ":" + msg +"This msg has been sent by"+user.getName());
        }
    }
}
