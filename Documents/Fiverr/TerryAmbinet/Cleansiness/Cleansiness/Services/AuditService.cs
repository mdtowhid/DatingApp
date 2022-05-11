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

        private decimal CalculateGrandAuditTotal(int pAuditMasterId)
        {
            var vAuditDetails = GetAuditDetails(pAuditMasterId, 0);
            int vNACount = 0;
            int vNoCount = 0;
            int vYesCount = 0;
            int vAuditDetailsCount = vAuditDetails.Count;

            foreach (var auditDetail in vAuditDetails)
            {
                if (auditDetail.Result == 1)
                {
                    vYesCount += 1;
                }
                if (auditDetail.Result == 2)
                {
                    vNoCount += 1;
                }
                if (auditDetail.Result == 3)
                {
                    vNACount += 1;
                }
            }

            //SCORE=(T-N-nA)/(T-nA) x 100%
            decimal fp1 = (vAuditDetailsCount - vNoCount - vNACount);
            decimal fp2 = (vAuditDetailsCount - vNACount);
            decimal fpRes = (fp1 == 0 && fp2 == 0) ? 0 : fp1 / fp2;
            decimal vTotalScore = Math.Round(fpRes * 100);
            return vTotalScore;
        }

        public AuditDetailCreationDto AddOrUpdateAuditDetail(AuditDetailCreationDto pAuditDetailCreationDto)
        {
            AuditDetailCreationDto vModel = new();
            vModel.ResponseType = ResponseType.Error;

            try
            {
                bool vIsSaved = false;
                int vNACount = 0;
                int vNoCount = 0;
                int vAuditQuestionCount = pAuditDetailCreationDto.QuestionList.Count;
                int vTotalQuestions = _common.GetQuestions().Count;
                foreach (var question in pAuditDetailCreationDto.QuestionList)
                {
                    if (question.ResultDropdownId == 3)
                    {
                        vNACount += 1;
                    }
                    if (question.ResultDropdownId == 2)
                    {
                        vNoCount += 1;
                    }

                    #region SaveAuditDetails
                    
                    if (pAuditDetailCreationDto.IsCreateForm)
                    {
                        AuditDetail vAuditDetail = new AuditDetail
                        {
                            AuditMasterID = pAuditDetailCreationDto.MasterId,
                            Comment = question.Comment,
                            QuestID = question.QuestsID,
                            Result = question.ResultDropdownId,
                            UpdateDt = DateTime.Now,
                            SectionID = pAuditDetailCreationDto.SectionId,
                        };

                        _context.AuditDetails.Add(vAuditDetail);
                    }
                    else
                    {
                        var vAuditDetail = _context.AuditDetails
                            .FirstOrDefault(x => x.AuditDetailsID == question.AuditDetailsID);
                        if (vAuditDetail != null)
                        {
                            vAuditDetail.Comment = question.Comment;
                            vAuditDetail.Result = question.ResultDropdownId;
                            vAuditDetail.UpdateDt = DateTime.Now;

                            _context.AuditDetails.Update(vAuditDetail);
                        }

                    }

                    #endregion
                }

                vIsSaved = _context.SaveChanges() > 0;

                //Save SectionTrack info here
                if (vIsSaved)
                {
                    //SCORE=(T-N-nA)/(T-nA) x 100%
                    decimal fp1 = (vAuditQuestionCount - vNoCount - vNACount);
                    decimal fp2 = (vAuditQuestionCount - vNACount);
                    decimal fpRes = 0;
                    if (fp2==0)
                    {
                    }
                    else
                    {
                        fpRes = (fp1 == 0 && fp2 == 0) ? 0 : fp1 / fp2;
                    }
                    
                    decimal vScore = Math.Round(fpRes * 100);

                    SectionTrack vSectionTrack = new SectionTrack();
                    var vSec = _context.SectionTracks.FirstOrDefault(x => x.AuditMasterID == pAuditDetailCreationDto.MasterId
                            && x.SectionID == pAuditDetailCreationDto.SectionId);

                    if (vSec != null)
                    {
                        vSec.UpdateDate = DateTime.Now;
                        vSec.SectionScore = vScore;
                        _context.SectionTracks.Update(vSec);
                    }
                    else
                    {
                        vSectionTrack = new SectionTrack()
                        {
                            AuditMasterID = pAuditDetailCreationDto.MasterId,
                            SectionID = pAuditDetailCreationDto.SectionId,
                            SectionScore = vScore,
                            SectionStatus = 1,
                            UpdateDate = DateTime.Now
                        };
                        _context.SectionTracks.Add(vSectionTrack);
                    }

                    vIsSaved = _context.SaveChanges() > 0;

                    //UPDATE AUDIT MASTER SCORE/STATUS
                    var vAuditMaster
                        = _context.AuditMasters.FirstOrDefault(x => x.AuditMasterID == pAuditDetailCreationDto.MasterId);

                    if (vAuditMaster != null)
                    {
                        var SectionTracks = _context.SectionTracks.Where(x =>
                            x.AuditMasterID == pAuditDetailCreationDto.MasterId).ToList();
                        var vSections = _context.Sections.ToList();
                        if (SectionTracks != null)
                        {
                            vAuditMaster.AuditScore = CalculateGrandAuditTotal(pAuditDetailCreationDto.MasterId);
                            vAuditMaster.AuditStatus = SectionTracks.Count == vSections.Count ? 1 : 0;
                            vAuditMaster.UpdateDt = DateTime.Now;
                            _context.AuditMasters.Update(vAuditMaster);
                            vIsSaved = _context.SaveChanges() > 0;
                        }
                    }
                }
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

        public AuditMaster GetAuditMasterById(int pAuditId)
        {
            var vAuditMaster = _context.AuditMasters
                .Include(x=>x.AppUser).Include(x=>x.Area).Include(x=>x.Area.Division)
                .Include(x => x.Area.Risk).FirstOrDefault(x => x.AuditMasterID == pAuditId);

            return vAuditMaster;
        }

        public List<AuditMaster> GetAuditMasters(AuditMasterSearchDto pAuditMasterSearchDto)
        {
            List<AuditMaster> vModelList = new();
            try
            {
                if (pAuditMasterSearchDto.IsCompleted)
                {
                    if (pAuditMasterSearchDto.FromDate != default(DateTime) && pAuditMasterSearchDto.ToDate != default(DateTime)
                        && pAuditMasterSearchDto.SearchText != null)
                    {
                        vModelList = _context.AuditMasters
                            .Where(x => x.AuditDate >= pAuditMasterSearchDto.FromDate
                            && x.AuditDate <= pAuditMasterSearchDto.ToDate && x.Area.AreaName
                            .Contains(pAuditMasterSearchDto.SearchText)
                            && (x.AuditStatus == 1 || x.AuditStatus == 2))
                            .Include(x => x.Area).Include(x => x.AppUser).Include(x => x.Area.Risk).ToList();
                    }
                    else if (pAuditMasterSearchDto.FromDate != default(DateTime) 
                        && pAuditMasterSearchDto.ToDate != default(DateTime))
                    {
                        vModelList = _context.AuditMasters
                            .Where(x => x.AuditDate >= pAuditMasterSearchDto.FromDate
                            && x.AuditDate <= pAuditMasterSearchDto.ToDate
                            && (x.AuditStatus == 1 || x.AuditStatus == 2))
                            .Include(x => x.Area).Include(x => x.AppUser).Include(x => x.Area.Risk).ToList();
                    }
                    else if(pAuditMasterSearchDto.SearchText != null)
                    {
                        vModelList = _context.AuditMasters
                            .Where(x => x.Area.AreaName.Contains(pAuditMasterSearchDto.SearchText)
                                && (x.AuditStatus == 1 || x.AuditStatus == 2))
                                .Include(x => x.Area).Include(x => x.AppUser)
                                .Include(x => x.Area.Risk).ToList();
                    }
                    else
                    {
                        vModelList = _context.AuditMasters.Where(x => x.AuditStatus == 1 || x.AuditStatus == 2)
                            .Include(x => x.Area).Include(x => x.AppUser)
                            .Include(x => x.Area.Risk).ToList();
                    }

                    //vModelList = vModelList.Count > 0 ? vModelList : _context.AuditMasters.Where(x => x.AuditStatus == 1 || x.AuditStatus == 2)
                    //        .Include(x => x.Area).Include(x => x.AppUser).ToList();
                }
                else
                {
                    vModelList = _context.AuditMasters.Where(x => x.AuditStatus == 0)
                        .Include(x => x.Area).Include(x => x.AppUser).Include(x => x.Area.Risk).ToList();
                }
            }
            catch (Exception ex)
            {
            }

            return vModelList;
        }



        public List<AuditDetail> GetAuditDetailsReport(int pMasterId, int pSectionId)
        {
            List<AuditDetail> vAuditDetails = new();
            vAuditDetails =
                _context.AuditDetails.Include(x => x.Question)
                .Include(x=>x.Question.Aspect)
                .Where(x => x.AuditMasterID == pMasterId && x.SectionID == pSectionId).ToList();
            return vAuditDetails;
        }

        public SectionTrack GetSectionTrack(int pMasterId, int pSectionId)
        {
            SectionTrack vModel = new();

            if (pMasterId != 0 && pSectionId != 0)
            {
                vModel = _context.SectionTracks.FirstOrDefault(x => x.AuditMasterID == pMasterId && x.SectionID == pSectionId);
                return vModel;
            }
            if (pMasterId != 0)
            {
                vModel = _context.SectionTracks.FirstOrDefault(x => x.AuditMasterID == pMasterId);
                return vModel;
            }

            if (pMasterId != 0)
            {
                vModel = _context.SectionTracks.FirstOrDefault(x => x.SectionTrackID == pSectionId);
                return vModel;
            }

            return vModel;
        }

        public List<AuditDetail> GetAuditDetails(int pMasterId, int pSectionId)
        {
            List<AuditDetail> vModel = new();
            if (pMasterId != 0 && pSectionId != 0)
            {
                vModel = _context.AuditDetails.Include(x=>x.Question.Aspect).Where(x => x.AuditMasterID == pMasterId && x.SectionID == pSectionId).ToList();
                return vModel;
            }
            if (pMasterId != 0)
            {
                vModel = _context.AuditDetails.Include(x => x.Question.Aspect).Where(x => x.AuditMasterID == pMasterId).ToList();
                return vModel;
            }

            return vModel;
        }

        public List<SectionTrack> GetSectionTracks(int pMasterId)
        {
            return _context.SectionTracks.Where(x => x.AuditMasterID == pMasterId).ToList();
        }

        public bool VerifyAudit(VerifyAuditDto pVerifyAuditDto)
        {
            string vOut = "";
            bool vIsSaved = false;
            try
            {
                var vAuditMaster = _context.AuditMasters
                    .FirstOrDefault(x => x.AuditMasterID == pVerifyAuditDto.MasterId);
                if(vAuditMaster!=null)
                {
                    vAuditMaster.AuditStatus = 2;
                    vAuditMaster.UpdateDt = DateTime.Now;
                    vAuditMaster.VerifyDate = DateTime.Now;
                    vAuditMaster.VerifyComments = pVerifyAuditDto.VerifyComments;
                    vAuditMaster.VerifiedBy = pVerifyAuditDto.VerifiedBy;

                    _context.AuditMasters.Update(vAuditMaster);
                    vIsSaved = _context.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                vOut = ex.Message;
                throw;
            }

            return vIsSaved;
        }
    }
}
