using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_ConfigEmail")]
    public class tbl_ConfigEmail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Nullable<int> STT { get; set; }

        [Key]
        public string Thongso { get; set; }

        [Required]
        public string TenThongso { get; set; }

        [Required]
        public string Giatri { get; set; }
    }
}