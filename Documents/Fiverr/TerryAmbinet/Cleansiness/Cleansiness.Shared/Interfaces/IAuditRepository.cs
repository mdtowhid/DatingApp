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

        List<AuditDetail> GetAuditDetails();
        AuditDetail GetAuditDetailById(int pAuditId);
        AuditDetailCreationDto AddOrUpdateAuditDetail(AuditDetailCreationDto pAuditDetailCreationDto);

        List<SectionTrack> GetSectionTracks(int pMasterId);
        SectionTrack GetSectionTrack(int pSectionId);
    }
}
