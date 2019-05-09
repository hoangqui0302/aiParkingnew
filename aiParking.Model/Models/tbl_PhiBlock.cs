using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_PhiBlock")]
    public class tbl_PhiBlock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public byte Loaixe { get; set; }

        [Required]
        public byte BlockNo { get; set; }

        [Required]
        public byte soGio { get; set; }

        [Required]
        public decimal Phi { get; set; }
    }
}