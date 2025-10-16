using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmed.Model
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Crs_Name { get; set; }
    }
}
