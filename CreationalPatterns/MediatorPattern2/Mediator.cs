using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    internal class Mediator
    {
        ArrayList users;
        public Mediator() {
            users = new ArrayList();
        }
        public void Register(IUser user)
        {
            users.Add(user);
        }
        public void showMessage(string msg,IUser user)
        {
            foreach(IUser ur in users)
            {
                if(ur!=user)
                {
                    ur.update(msg,user);
                }
                
            }

        }
    }
}
