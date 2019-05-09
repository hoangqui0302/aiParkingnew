using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_TienCocThethang")]
    public class tbl_TienCocThethang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public System.Guid GUID { get; set; }

        [Key]
        public System.Guid IDBanTheThang { get; set; }

        [Required]
        public string TheID { get; set; }

        [Required]
        public decimal TienCoc { get; set; }
    }
}