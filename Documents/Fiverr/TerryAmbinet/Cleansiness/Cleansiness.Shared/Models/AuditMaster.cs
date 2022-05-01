using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Models
{
    [Table("AuditMaster")]
    public class AuditMaster : ModelBase
    {
        [Key]
        public int AuditMasterID { get; set; }
        [Required]
        public int AppUserID { get; set; }
        public virtual AppUser? AppUser { get; set; }
        [Required(ErrorMessage = "Please select area"), Display(Name = "Area")]
        public int AreaID { get; set; }
        public virtual Area? Area { get; set; }
        public DateTime AuditDate { get; set; }
        public decimal AuditScore { get; set; }
        public DateTime UpdateDt { get; set; }
        //[Required(ErrorMessage = "Please select site"), Display(Name = "Site")]

        public int AuditStatus { get; set; }
        public string? VerifiedBy { get; set; }
        public string? VerifyComments { get; set; }
        public DateTime VerifyDate{ get; set; }
    }
}
