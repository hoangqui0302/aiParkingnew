using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_SendMail")]
    public class tbl_SendMail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.DateTime NgayCa { get; set; }

        [Key]
        public byte CaTruc { get; set; }

        [Required]
        public System.DateTime ThoiGianBD { get; set; }

        [Required]
        public System.DateTime ThoiGianKT { get; set; }

        [Required]
        public bool LaCaCuoiNgay { get; set; }

        [Required]
        public bool DagoiMail { get; set; }
    }
}