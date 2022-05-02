using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("AuditDetails")]
    public class AuditDetail
    {
        [Key]
        public int AuditDetailsID { get; set; }
        public int AuditMasterID { get; set; }
        public int SectionID { get; set; }
        public int QuestID { get; set; }
        public int Result { get; set; }
        public string? Comment { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
