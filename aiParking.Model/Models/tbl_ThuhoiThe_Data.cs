using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_ThuhoiThe_Data")]
    public class tbl_ThuhoiThe_Data
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Key]
        public System.Guid IDThuhoiThe { get; set; }

        [Required]
        public string Bienso { get; set; }

        [Required]
        public string TheID { get; set; }

        [Required]
        public decimal TienCoc { get; set; }
    }
}