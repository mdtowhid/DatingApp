﻿using AutoMapper;
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
                }

                vIsSaved = _context.SaveChanges() > 0;

                //Save SectionTrack info here
                if (vIsSaved)
                {
                    decimal y = Decimal.Divide(vAudutQuestionCount, vTotalQuestions - vNotApplicableCount);
                    decimal z = Math.Ceiling(y * 100);
                    SectionTrack vSectionTrack = new SectionTrack();
                    var vSec = _context.SectionTracks.FirstOrDefault(x => x.AuditMasterID == pAuditDetailCreationDto.MasterId
                            && x.SectionID == pAuditDetailCreationDto.SectionId);

                    if(vSec != null)
                    {
                        vSec.UpdateDate = DateTime.Now;
                        vSec.SectionStatus = pAuditDetailCreationDto.SectionStatus;
                        vSec.SectionScore = z;
                        _context.SectionTracks.Update(vSec);
                    }
                    else
                    {
                        vSectionTrack = new SectionTrack()
                        {
                            AuditMasterID = pAuditDetailCreationDto.MasterId,
                            SectionID = pAuditDetailCreationDto.SectionId,
                            SectionScore = z,
                            SectionStatus = pAuditDetailCreationDto.SectionStatus,
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
                            vAuditMaster.AuditScore = SectionTracks.Sum(x => x.SectionScore);
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

        public SectionTrack GetSectionTrack(int pMasterId, int pSectionId)
        {
            SectionTrack vModel = new();

            if(pMasterId!=0 && pSectionId != 0)
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
                vModel = _context.AuditDetails.Where(x => x.AuditMasterID == pMasterId && x.SectionID == pSectionId).ToList();
            }

            return vModel;
        }
    }
}
