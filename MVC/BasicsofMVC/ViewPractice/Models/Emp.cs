using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewPractice.Models
{
    public class Emp
    {

        public int id { get; set; }
        [Required]
        public string name { get; set; }

    }
}