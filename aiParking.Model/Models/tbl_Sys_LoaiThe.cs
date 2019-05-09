using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_Sys_LoaiThe")]
    public class tbl_Sys_LoaiThe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte LoaiThe { get; set; }

        [Required]
        public string Mota { get; set; }
    }
}