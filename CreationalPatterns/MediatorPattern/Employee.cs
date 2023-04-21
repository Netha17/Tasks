using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Employee
    {
        private string EmpName;
        public int pendingProjects=5;
        public Employee(string name) 
        {
            EmpName = name;
        }
        public string getEmpName()
        {
            return EmpName;
        }

        

    }
}
