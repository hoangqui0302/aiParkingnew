using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_Sys_ThoigianThethang")]
    public class tbl_Sys_ThoigianThethang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte ID { get; set; }

        [Required]
        public string Mota { get; set; }

        [Required]
        public byte LoaiThoigian { get; set; }

        public string GioBD { get; set; }
        public string GioKT { get; set; }
        public Nullable<byte> SoGio { get; set; }
    }
}