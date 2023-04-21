using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CateringServicesApplication.Models
{
    public class OrderModel
    {
        #region properties
        [Required(ErrorMessage = "Name is required")]
       
        public String Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]

        public String Email { get; set; }
        
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Mobile { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        #endregion
    }
}