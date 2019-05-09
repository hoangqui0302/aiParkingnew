using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_Hinhxe")]
    public class tbl_Hinhxe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string ID { get; set; }

        [Required]
        public byte[] hinhCameraTruoc { get; set; }

        [Required]
        public byte[] hinhCameraSau { get; set; }

        public byte[] hinhCameraNhandang { get; set; }
    }
}