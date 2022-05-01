using Cleansiness.Helpers;
using Cleansiness.Shared.DTO;
using Cleansiness.Shared.Enums;
using Cleansiness.Shared.Interfaces;
using Cleansiness.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Cleansiness.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICommonRepository _common;
        private readonly IAuditRepository _repo;

        public AdminController(ICommonRepository common, IAuditRepository repo)
        {
            _common = common;
            _repo = repo;
        }
        public IActionResult Dashboard(int? pResp, string? pMesg, int? pPage)
        {
            AuditMasterCreationDto vDto = new AuditMasterCreationDto()
            {
                Areas = _common.GetAreas(),
                Sites = _common.GetSites()
            };
            vDto.AppUserID = SessionHelper.GetUserId(HttpContext);
            DashboardDto vDashboardDto = new();
            ViewBag.AuditMasterList = _repo.GetAuditMasters().ToPagedList(pPage ?? 1, 3);
            vDashboardDto.AuditMasterCreationDto = vDto;
            if(pResp!=null && pMesg!=null)
            {
                vDashboardDto.ResponseType = ResponseType.Error;
                vDashboardDto.Message = pMesg;
            }
            return View(vDashboardDto);
        }

        [HttpPost]
        public IActionResult StartAudit(DashboardDto pDashboardDto)
        {
            pDashboardDto.AuditMasterCreationDto.AuditDate = DateTime.Now;
            AuditMaster vAuditMaster = _repo.AddOrUpdateAuditMaster(pDashboardDto.AuditMasterCreationDto);
            if(vAuditMaster!=null)
            {
                if(vAuditMaster.ResponseType == ResponseType.Error)
                {
                    return RedirectToAction("Dashboard", "Admin",
                        new { pResp = (int) vAuditMaster.ResponseType, pMesg= vAuditMaster.Message});
                }
            }
            return RedirectToAction("AuditSections", "Admin", new { pAuditMasterId = 0});
        }
        
        [HttpGet("AuditSections/{pAuditMasterId}")]
        public IActionResult AuditSections(int pAuditMasterId)
        {
            HttpContext.Session.SetString(SessionHelper.AuditMasterId, pAuditMasterId.ToString());
            AuditSectionDto vAuditSectionDto = new();
            vAuditSectionDto.SectionList = _common.GetSections();
            return View(vAuditSectionDto);
        }
        
        public IActionResult AuditQuestions(int pSectionId)
        {
            HttpContext.Session.SetString(SessionHelper.AuditSectionId, pSectionId.ToString());
            AuditQuestionDto vAuditQuestionDto = new();
            vAuditQuestionDto.QuestionList = _common.GetQuestionsBySectionId(pSectionId);
            vAuditQuestionDto.SectionName = _common.GetSectionNameById(pSectionId).SectionName;
            vAuditQuestionDto.AuditMasterId = SessionHelper.GetCurrentAuditMasterId(HttpContext);
            return View(vAuditQuestionDto);
        }
        
        [HttpPost]
        public IActionResult AddAuditQuestions(AuditQuestionDto auditQuestionDto)
        {
            float vAuditScore = 0;
            int vNotApplicableCount = 0;
            int vAudutQuestionCount = auditQuestionDto.QuestionList.Count;
            int vTotalQuestions = _common.GetQuestions().Count;
            foreach (var question in auditQuestionDto.QuestionList)
            {
                if(question.Answere == 3)
                {
                    vNotApplicableCount += 1;
                }
            }

            //double x = (vTotalQuestions / (auditQuestionDto.QuestionList.Count - vNotApplicableCount));

            var c = vTotalQuestions - vNotApplicableCount;
            decimal y = Decimal.Divide(vAudutQuestionCount, c) ;
            decimal z = y * 100;
            return RedirectToAction("AuditQuestions", "Admin"
                , new { pSectionId = SessionHelper.GetCurrentSectionId(HttpContext) });
        }
        
        public IActionResult AuditList()
        {
            return View();
        }
    }
}
