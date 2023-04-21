using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models

{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Branch { get; set; }
        [Required]
        public string Section { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
