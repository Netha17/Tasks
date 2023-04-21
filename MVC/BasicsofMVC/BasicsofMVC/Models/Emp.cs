using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicsofMVC.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set;}
    }
}