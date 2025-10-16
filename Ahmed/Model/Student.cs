using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmed.Model
{
    public class Student
    {
  
        [Key]
        public int Id { get; set; }
        [Required]
        public string Std_Name { get; set; }
        [Required]
        public string UserName { get; set;}
        [Required]
        public string Password  { get; set;}
        [Required]
        public int Age {  get; set; }
    }
}
