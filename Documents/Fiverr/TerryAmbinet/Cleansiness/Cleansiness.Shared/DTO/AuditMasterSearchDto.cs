using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class AuditMasterSearchDto
    {
        public bool IsCompleted { get; set; }
        public DateTime FromDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public DateTime ToDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        public string SearchText { get; set; }
        public int SiteId { get; set; }
    }
}
