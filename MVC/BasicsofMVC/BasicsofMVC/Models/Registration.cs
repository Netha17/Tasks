using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicsofMVC.Models
{
    public class Registration
    {
        #region properties
        [Required(ErrorMessage = "Name is required")]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]

        public String Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Required]

        public int Mobile { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }
        #endregion
      

    }
}