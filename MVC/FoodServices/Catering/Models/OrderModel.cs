using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catering.Models
{
    public class OrderModel
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Username is required")]

        public string Username { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        //[RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile Number")]
        [MaxLength(10,ErrorMessage ="Mobile number must contain only 10 digits")]
        public Int64 Phonenumber { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}