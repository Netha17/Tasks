using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Accountant
    {
        public void settleBalance(Mediator m,Employee e)
        {
            if(m.approvalFromManager && m.approvalFromHR)
            {
                Console.WriteLine("Congratulations " + e.getEmpName()+"Your resignation has approved and balance salary has been credited to your account"); ;

            }
            else
            {
                Console.WriteLine("Sorry, your resignation has been rejected");
            }
            

        }
    }
}
