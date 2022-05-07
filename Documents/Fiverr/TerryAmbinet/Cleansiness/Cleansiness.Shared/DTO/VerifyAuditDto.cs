using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class VerifyAuditDto
    {
        public int MasterId { get; set; }
        public string VerifyComments { get; set; }
        public string VerifiedBy { get; set; }
    }
}
