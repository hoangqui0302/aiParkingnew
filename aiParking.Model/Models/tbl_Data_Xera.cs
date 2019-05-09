using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_Data_Xera")]
    public class tbl_Data_Xera
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string ID { get; set; }

        [Required]
        public string IDXeVao { get; set; }

        [Required]
        public string TheID { get; set; }

        [Required]
        public System.DateTime NgayGioRa { get; set; }

        [Required]
        public byte LoaiThe { get; set; }

        [Required]
        public byte LoaiXe { get; set; }

        [Required]
        public string Bienso { get; set; }

        [Required]
        public string BiensoVao { get; set; }

        [Required]
        public string BienDangky { get; set; }

        [Required]
        public byte CatrucRa { get; set; }

        [Required]
        public string maNhanvienRa { get; set; }

        [Required]
        public byte CabinRa { get; set; }

        [Required]
        public byte LanRa { get; set; }

        [Required]
        public string DienGiaiPhi { get; set; }

        [Required]
        public decimal Phi { get; set; }

        [Required]
        public System.DateTime NgayGioVao { get; set; }

        [Required]
        public byte CatrucVao { get; set; }

        [Required]
        public string maNhanvienVao { get; set; }

        [Required]
        public byte CabinVao { get; set; }

        [Required]
        public byte LanVao { get; set; }

        [Required]
        public byte IDThoigianTheThang { get; set; }

        [Required]
        public byte ValidityCode { get; set; }
    }
}