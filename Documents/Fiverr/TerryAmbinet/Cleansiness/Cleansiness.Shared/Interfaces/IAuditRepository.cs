using Cleansiness.Shared.DTO;
using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Interfaces
{
    public interface IAuditRepository
    {
        List<AuditMaster> GetAuditMasters();
        AuditMaster GetAuditMasterById(int pAuditId);
        AuditMaster AddOrUpdateAuditMaster(AuditMasterCreationDto pAuditMasterCreationDto);

        AuditDetail GetAuditDetailById(int pAuditId);
        AuditDetailCreationDto AddOrUpdateAuditDetail(AuditDetailCreationDto pAuditDetailCreationDto);

        List<AuditDetail> GetAuditDetails(int pMasterId, int pSectionId);
        SectionTrack GetSectionTrack(int pMasterId, int pSectionId);
    }
}
