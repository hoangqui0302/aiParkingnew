using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aiParking.Model.Models
{
    [Table("tbl_KhachHang")]
   public class tbl_KhachHang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string MaKhachhang { get; set; }
        [Required]
        public string TenKhachhang { get; set; }
        [Required]
        public string Diachi { get; set; }
        [Required]
        public string Dienthoai { get; set; }
        [Required]
        public string DiDong { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string maNhanvienTao { get; set; }
        [Required]
        public Nullable<System.DateTime> NgayTao { get; set; }
        [Required]
        public byte TrangThai { get; set; }
    }
}
