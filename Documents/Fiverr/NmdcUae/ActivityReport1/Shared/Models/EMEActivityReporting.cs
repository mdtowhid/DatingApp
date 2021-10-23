using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityReport1.Shared.Models
{
    public class EMEActivityReporting
    {
        public int Id { get; set; }
        public int ProjEmeReportDailyId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }
        public int ProjActivityMainId { get; set; }
        public string Category { get; set; }
        public string EmePlatenumberName { get; set; }
        public int EmePlatenumberId { get; set; }
        public string Remarks { get; set; }
        public bool? IsApproved { get; set; }
    }
}
