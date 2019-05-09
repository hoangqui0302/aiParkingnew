using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_Thethang")]
    public class tbl_Thethang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Required]
        public System.Guid IDBanTheThang { get; set; }

        [Required]
        public string TheID { get; set; }

        [Required]
        public byte Loaixe { get; set; }

        [Required]
        public string Bienso { get; set; }

        [Required]
        public System.DateTime NgayBDHieuluc { get; set; }

        [Required]
        public System.DateTime NgayKTHieuluc { get; set; }

        [Required]
        public byte Thang { get; set; }

        [Required]
        public int Nam { get; set; }

        [Required]
        public decimal Phi { get; set; }

        [Required]
        public byte IDThoigianThethang { get; set; }
    }
}