using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_ThongtinXe")]
    public class tbl_ThongtinXe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Bienso { get; set; }

        [Required]
        public byte Loaixe { get; set; }

        [Required]
        public string NguoiDungten { get; set; }

        [Required]
        public string NhanHieu { get; set; }

        [Required]
        public string Mauson { get; set; }

        [Required]
        public string maKhachHang { get; set; }

        [Required]
        public string maNhanVienDangky { get; set; }

        [Required]
        public System.DateTime NgayDangky { get; set; }

        [Required]
        public byte TrangThai { get; set; }

        [Required]
        public string TheID { get; set; }

        [Required]
        public decimal TienCoc { get; set; }

        public Nullable<byte> IDThoigianThethang { get; set; }
    }
}