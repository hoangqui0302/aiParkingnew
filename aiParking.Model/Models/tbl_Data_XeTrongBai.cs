using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_Data_XeTrongBai")]
    public class tbl_Data_XeTrongBai
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string ID { get; set; }

        [Required]
        public string TheID { get; set; }

        [Required]
        public byte LoaiThe { get; set; }

        [Required]
        public byte Loaixe { get; set; }

        [Required]
        public string Bienso { get; set; }

        [Required]
        public string BienDangky { get; set; }

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
        public byte[] hinhCameraTruoc { get; set; }

        [Required]
        public byte[] hinhCameraSau { get; set; }

        [Required]
        public byte[] hinhCameraNhandang { get; set; }

        [Required]
        public byte IDThoigianTheThang { get; set; }

        [Required]
        public byte ValidityCode { get; set; }
    }
}