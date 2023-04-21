using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Manager
    {
        public bool sendApprovalForResignation(Employee employee)
        {
            if (employee.pendingProjects==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
