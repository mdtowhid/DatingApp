using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class AuditReportDto
    {
        //public AppUser AppUser { get; set; }
        public AuditMaster AuditMaster { get; set; }
        public bool IsVerified { get; set; }
    }
}
