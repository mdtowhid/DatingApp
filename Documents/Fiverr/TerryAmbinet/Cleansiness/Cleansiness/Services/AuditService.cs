using AutoMapper;
using Cleansiness.Models;
using Cleansiness.Shared.DTO;
using Cleansiness.Shared.Enums;
using Cleansiness.Shared.Interfaces;
using Cleansiness.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Cleansiness.Services
{
    public class AuditService : IAuditRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AuditService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public AuditDetail AddOrUpdateAuditDetail(AuditDetail pAuditDetail)
        {
            throw new NotImplementedException();
        }

        public AuditMaster AddOrUpdateAuditMaster(AuditMasterCreationDto pAuditMasterCreationDto)
        {
            AuditMaster vModel = new();
            bool vIsSaved;

            try
            {
                vModel = _mapper.Map<AuditMaster>(pAuditMasterCreationDto);
                if (pAuditMasterCreationDto.AuditMasterID == 0)
                {
                    _context.AuditMasters.Add(vModel);
                    vIsSaved = _context.SaveChanges() > 0;
                    vModel.ResponseType = vIsSaved ? ResponseType.Add : ResponseType.Error;
                    vModel.Message = vIsSaved ? "Saved successfully" : "There is an error while adding Audit Master info.";
                }
                else
                {
                    _context.AuditMasters.Update(vModel);
                    vIsSaved = _context.SaveChanges() > 0;
                    vModel.ResponseType = vIsSaved ? ResponseType.Add : ResponseType.Error;
                    vModel.Message = vIsSaved ? "Updated successfully" : "There is an error while updating Audit Master info.";
                }
            }
            catch (Exception ex)
            {
                vModel.ResponseType = ResponseType.Error;
                vModel.Message = ex.Message;
            }

            return vModel;
        }

        public AuditDetail GetAuditDetailById(int pAuditId)
        {
            throw new NotImplementedException();
        }

        public List<AuditDetail> GetAuditDetails()
        {
            throw new NotImplementedException();
        }

        public AuditMaster GetAuditMasterById(int pAuditId)
        {
            throw new NotImplementedException();
        }

        public List<AuditMaster> GetAuditMasters()
        {
            List<AuditMaster> vModelList = new();
            try
            {
                vModelList = _context.AuditMasters.Include(x => x.Area)
                    .Include(x => x.AppUser).Include(x => x.Site).ToList();
            }
            catch (Exception ex)
            {
            }

            return vModelList;
        }
    }
}
