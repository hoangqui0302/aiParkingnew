using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aiParking.Model.Models
{
    [Table("tbl_Sys_CaTruc")]
   public class tbl_Sys_CaTruc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte CaTruc { get; set; }
        [Required]
        public string GioBD { get; set; }
        [Required]
        public string GioKT { get; set; }
        [Required]
        public string GhiChu { get; set; }
    }
}
