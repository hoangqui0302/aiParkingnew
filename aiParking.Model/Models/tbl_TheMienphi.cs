using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_TheMienphi")]
    public class tbl_TheMienphi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public string TheID { get; set; }

        [Required]
        public string Bienso { get; set; }

        [Required]
        public byte Loaixe { get; set; }

        public string maKhachHang { get; set; }

        [Required]
        public System.DateTime NgayBDHieuluc { get; set; }

        [Required]
        public System.DateTime NgayKTHieuluc { get; set; }

        [Required]
        public string maNhanvienCap { get; set; }

        [Required]
        public System.DateTime NgayGioCap { get; set; }
    }
}