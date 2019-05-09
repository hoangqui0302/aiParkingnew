using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_PhiThangTheoThoigian")]
    public class tbl_PhiThangTheoThoigian
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public byte LoaiXe { get; set; }

        [Required]
        public byte IDThoigianThethang { get; set; }

        [Required]
        public decimal Phi { get; set; }
    }
}