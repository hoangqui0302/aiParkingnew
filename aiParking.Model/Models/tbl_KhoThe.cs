using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_KhoThe")]
    public class tbl_KhoThe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string TheID { get; set; }

        [Required]
        public int SoThe { get; set; }

        [Required]
        public byte LoaiThe { get; set; }

        [Required]
        public byte LoaiXe { get; set; }

        [Required]
        public string maNhanvienPhathanh { get; set; }

        [Required]
        public System.DateTime NgayGioPhathanh { get; set; }

        [Required]
        public byte TrangThai { get; set; }
    }
}