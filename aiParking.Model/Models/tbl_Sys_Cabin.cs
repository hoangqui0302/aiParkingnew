using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aiParking.Model.Models
{
    [Table("tbl_Sys_Cabin")]
   public class tbl_Sys_Cabin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte Cabin { get; set; }
        [Required]
        public string Mota { get; set; }
    }
}
