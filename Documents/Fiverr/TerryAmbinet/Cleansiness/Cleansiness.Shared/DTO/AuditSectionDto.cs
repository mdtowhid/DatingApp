using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class AuditSectionDto : ModelBase
    {
        public List<Section> SectionList { get; set; }
        public int SectionCompletedCount { get; set; }
        public decimal TotalScore { get; set; }
    }
}
