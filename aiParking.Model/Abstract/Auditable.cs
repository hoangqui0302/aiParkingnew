using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aiParking.Model.Abstract
{
   public abstract class Auditable:IAuditable
    {

       public DateTime? CreateDate { set; get; }
        [MaxLength(256)]
       public string CreateBy { set; get; }
       public DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
        public string UpdateBy { set; get; }
    }
}
