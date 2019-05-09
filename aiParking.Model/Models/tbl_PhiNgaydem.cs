using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_PhiNgaydem")]
    public class tbl_PhiNgaydem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte LoaiXe { get; set; }

        [Required]
        public decimal PhiNgay { get; set; }

        [Required]
        public decimal PhiDem { get; set; }

        [Required]
        public decimal PhingayDem { get; set; }
    }
}