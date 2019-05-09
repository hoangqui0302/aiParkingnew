using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_DoanhThu")]
    public class tbl_DoanhThu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public System.DateTime NgayCa { get; set; }

        [Required]
        public System.DateTime NgaygioVaoca { get; set; }

        [Required]
        public Nullable<System.DateTime> NgaygioRaca { get; set; }

        [Required]
        public byte Catruc { get; set; }

        [Required]
        public string maNhanvien { get; set; }

        [Required]
        public byte Cabin { get; set; }
    }
}