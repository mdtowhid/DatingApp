using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class DashboardDto : ModelBase
    {
        public AuditMasterCreationDto AuditMasterCreationDto { get; set; }
        public List<AuditMaster> AuditMasterList { get; set; }
        public List<AppUser> AppUserList { get; set; }
        public List<ActivityLog> ActivityLogs { get; set; }
        public AppUser AppUser { get; set; }
        public string UserName { get; set; }
        public bool IsSearched { get; set; }
        public AuditMasterSearchDto AuditMasterSearchDto { get; set; }
    }
}
