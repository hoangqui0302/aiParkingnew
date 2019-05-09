using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_ThuhoiThe")]
    public class tbl_ThuhoiThe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public string soPhieu { get; set; }

        [Required]
        public System.DateTime NgayGioThuhoi { get; set; }

        [Required]
        public string maNhanvienThuhoi { get; set; }

        [Required]
        public string maKhachHang { get; set; }

        [Required]
        public decimal ThanhTien { get; set; }
    }
}