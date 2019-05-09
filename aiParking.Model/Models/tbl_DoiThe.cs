using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_DoiThe")]
    public class tbl_DoiThe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public string TheIDMoi { get; set; }

        [Required]
        public string TheIDCu { get; set; }

        [Required]
        public string soPhieu { get; set; }

        [Required]
        public string Bienso { get; set; }

        [Required]
        public string maKhachHang { get; set; }

        [Required]
        public string maNhanvienPhatHanh { get; set; }

        [Required]
        public System.DateTime NgayGioPhatHanh { get; set; }

        [Required]
        public decimal PhiDoiThe { get; set; }

        [Required]
        public string Ghichu { get; set; }
    }
}