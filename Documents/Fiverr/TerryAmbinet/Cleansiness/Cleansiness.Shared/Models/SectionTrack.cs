using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("SectionTrack")]
    public class SectionTrack
    {
        [Key]
        public int SectionTrackID { get; set; }
        public int AuditMasterID { get; set; }
        public int SectionID { get; set; }
        public int SectionStatus { get; set; }
        public decimal SectionScore { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
