using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityReport1.Shared.Models
{
    class SCraftActivityReporting
    {
        public string Category { get; set; }
        public string SupportCraftName { get; set; }
        public int SupportCraftId { get; set; }
        public string Remarks { get; set; }
        public bool? IsApproved { get; set; }
        public int Id { get; set; }
        public int? ProjSupportCraftReportDailyId { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeFinish { get; set; }
        public int? ProjActivityMainId { get; set; }
    }
}
