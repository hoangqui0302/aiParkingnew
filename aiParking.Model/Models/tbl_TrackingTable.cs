using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_TrackingTable")]
    public class tbl_TrackingTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string TableName { get; set; }

        [Required]
        public string KeyColumn { get; set; }

        [Required]
        public long UpdatedVersion { get; set; }

        [Required]
        public byte RealTimeUpdate { get; set; }
    }
}