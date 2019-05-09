using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_BanTheThang")]
    public class tbl_BanTheThang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid GUID { get; set; }
        [Required]
        public string soPhieu { get; set; }
        [Required]
        public System.DateTime NgayGioBan { get; set; }
        [Required]
        public string maNhanvienBan { get; set; }
        [Required]
        public string maKhachHang { get; set; }
        [Required]
        public string tenKhachHang { get; set; }
        [Required]
        public string diaChi { get; set; }
        [Required]
        public decimal ThanhTien { get; set; }
    }
}