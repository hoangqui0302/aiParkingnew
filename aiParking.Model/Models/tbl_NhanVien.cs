using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_NhanVien")]
    public class tbl_NhanVien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string maNhanVien { get; set; }

        [Required]
        public string ho { get; set; }

        [Required]
        public string ten { get; set; }

        [Required]
        public string diaChi { get; set; }

        [Required]
        public string dienThoai { get; set; }

        [Required]
        public byte trangThai { get; set; }

        [Required]
        public System.DateTime ngayKhoiTao { get; set; }

        [Required]
        public string maNhanVienKhoiTao { get; set; }

        [Required]
        public string ghiChu { get; set; }

        [Required]
        public string matKhau { get; set; }
    }
}