using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_SendMail_Xevipham")]
    public class tbl_SendMail_Xevipham
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string ID { get; set; }

        [Required]
        public string Bienso { get; set; }

        [Required]
        public System.DateTime NgayGioVao { get; set; }

        [Required]
        public System.DateTime NgayGioRa { get; set; }

        [Required]
        public decimal Phi { get; set; }

        [Required]
        public string DienGiaiPhi { get; set; }

        [Required]
        public byte ValidityCode { get; set; }

        [Required]
        public bool DagoiMail { get; set; }
    }
}