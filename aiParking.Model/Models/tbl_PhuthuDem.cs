using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_PhuthuDem")]
    public class tbl_PhuthuDem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte Loaixe { get; set; }

        [Required]
        public decimal Phuthu { get; set; }
    }
}