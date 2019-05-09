using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_Sys_Loaixe")]
    public class tbl_Sys_Loaixe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte LoaiXe { get; set; }

        [Required]
        public string Mota { get; set; }

        [Required]
        public decimal PhiThang { get; set; }

        public Nullable<decimal> PhiQuy { get; set; }

        public Nullable<decimal> PhiNam { get; set; }
    }
}