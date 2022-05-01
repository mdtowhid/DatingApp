using AutoMapper;
using Cleansiness.Shared.DTO;
using Cleansiness.Shared.Models;

namespace Cleansiness.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AuditMaster, AuditMasterCreationDto>();
            CreateMap<AuditMasterCreationDto, AuditMaster>();
        }

    }
}
