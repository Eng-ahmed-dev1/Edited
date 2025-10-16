using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmed.Model
{
    public class Std_Crs_Deg
    {
        [Key, Column(Order = 0)]
        public int Std_id { get; set; }
        [Key, Column(Order = 0)]
        public int Crs_id { get; set; }

        public decimal degree { get; set; }
        [ForeignKey("Std_id")]
        public virtual Student sudent { get; set; }
        [ForeignKey("Crs_id")]
        public virtual Course course { get; set; }
    }
}
