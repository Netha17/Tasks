using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BussinessLayer
{
    public class Employee
    {
        private IDataAccessLayer d;
        public Employee(IDataAccessLayer dataAccessLayer) 
        {
            d= dataAccessLayer;
        }
       public int GetAllEmployees()
        {
            return d.GetCountOfEmp();
        }
    }
}
