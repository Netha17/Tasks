using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Mediator
    {
        public bool approvalFromManager;
       public  bool approvalFromHR;
        
        public void resign(Employee employee)
        {
              approvalFromManager=new Manager().sendApprovalForResignation(employee);
             approvalFromHR=new HR().sendApprovalForResignation(employee);
            new Accountant().settleBalance(this,employee);



        }
    }
}
