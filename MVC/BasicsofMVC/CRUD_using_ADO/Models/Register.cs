using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_using_ADO.Models
{
    public class Register
    {
    
        public string Name { get; set; }
        public Int64 Mobile { get; set; }
        public double fee { get; set; }
    }
}