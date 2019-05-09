using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aiParking.Model.Models
{
    [Table("tbl_ConfigLanxe")]
    public class tbl_ConfigLanxe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Nullable<int> STT { get; set; }

        [Key]
        public int CabinID { get; set; }

        [Required]
        public string Thongso { get; set; }

        [Required]
        public string TenThongso { get; set; }

        [Required]
        public string Giatri { get; set; }
    }
}