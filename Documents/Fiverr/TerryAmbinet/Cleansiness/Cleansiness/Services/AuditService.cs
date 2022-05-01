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
        private readonly ICommonRepository _common;

        public AuditService(AppDbContext context, IMapper mapper, ICommonRepository common)
        {
            _context = context;
            _mapper = mapper;
            _common = common;
        }
        public AuditDetailCreationDto AddOrUpdateAuditDetail(AuditDetailCreationDto pAuditDetailCreationDto)
        {
            AuditDetailCreationDto vModel = new();
            vModel.ResponseType = ResponseType.Error;
            try
            {
                bool vIsSaved=false;
                int vNotApplicableCount = 0;
                int vAudutQuestionCount = pAuditDetailCreationDto.QuestionList.Count;
                int vTotalQuestions = _common.GetQuestions().Count;
                foreach (var question in pAuditDetailCreationDto.QuestionList)
                {
                    if (question.ResultDropdownId == 3)
                    {
                        vNotApplicableCount += 1;
                    }

                    if(pAuditDetailCreationDto.IsCreateForm)
                    {
                        AuditDetail vAuditDetail = new AuditDetail
                        {
                            AuditMasterID = pAuditDetailCreationDto.MasterId,
                            Comment = question.Comment,
                            QuestID = question.QuestsID,
                            Result = question.ResultDropdownId,
                            UpdateDt = DateTime.Now
                        };

                        _context.AuditDetails.Add(vAuditDetail);
                        vIsSaved = _context.SaveChanges() > 0;
                    }
                }

                vModel.ResponseType = vIsSaved ? ResponseType.Add : ResponseType.Error;
                vModel.Message = vIsSaved ? "" : "Error occured while saving";

                decimal y = Decimal.Divide(vAudutQuestionCount, vTotalQuestions - vNotApplicableCount);
                decimal z = Math.Ceiling(y * 100);

                //Save SectionTrack info here
                SectionTrack vSectionTrack = new SectionTrack()
                {
                    AuditMasterID = pAuditDetailCreationDto.MasterId,
                    SectionID = pAuditDetailCreationDto.SectionId,
                    SectionScore = z,
                    SectionStatus = pAuditDetailCreationDto.SectionStatus,
                    UpdateDate = DateTime.Now
                };

                _context.SectionTracks.Add(vSectionTrack);
                vIsSaved = _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                vModel.Message = ex.Message;
                vModel.ResponseType = ResponseType.Error;
            }

            return vModel;
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
                    .Include(x => x.AppUser).ToList();
            }
            catch (Exception ex)
            {
            }

            return vModelList;
        }

        public SectionTrack GetSectionTrack(int pSectionId)
        {
            throw new NotImplementedException();
        }

        public List<SectionTrack> GetSectionTracks(int pMasterId)
        {
            throw new NotImplementedException();
        }
    }
}
