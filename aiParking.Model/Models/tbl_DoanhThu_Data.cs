using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_DoanhThu_Data")]
    public class tbl_DoanhThu_Data
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public System.Guid IDDoanhThu { get; set; }

        [Required]
        public byte LoaiThe { get; set; }

        [Required]
        public byte LoaiXe { get; set; }

        [Required]
        public decimal Menhgia { get; set; }

        [Required]
        public int Soluong { get; set; }

        [Required]
        public decimal Phi { get; set; }
    }
}