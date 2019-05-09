using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_QuyenNhanvien")]
    public class tbl_QuyenNhanvien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public string maNhanVien { get; set; }

        [Required]
        public byte quyen { get; set; }

        [Required]
        public string ghiChu { get; set; }
    }
}