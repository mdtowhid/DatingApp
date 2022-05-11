using Cleansiness.Helpers;
using Cleansiness.Shared.DTO;
using Cleansiness.Shared.Enums;
using Cleansiness.Shared.Interfaces;
using Cleansiness.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace Cleansiness.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICommonRepository _common;
        private readonly IAuditRepository _repo;
        private readonly IConfiguration _config;

        public AdminController(ICommonRepository common, IAuditRepository repo, IConfiguration config)
        {
            _common = common;
            _repo = repo;
            _config = config;
        }
        public IActionResult Dashboard(int? pResp, string? pMesg, int? pPage)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            AuditMasterCreationDto vDto = new();
            
            var vAppUser = JsonConvert.DeserializeObject<AppUser>(HttpContext.Session.GetString(SessionHelper.AppUser));
            vDto.AppUserID = SessionHelper.GetUserId(HttpContext);
            vDto.Areas = _common.GetAreas(vAppUser.SiteId);
            vDto.Sites = _common.GetSites();
            
            DashboardDto vDashboardDto = new();
            vDashboardDto.AppUser = vAppUser;
            vDashboardDto.AppUserList = _common.GetAppUsers();
            vDashboardDto.UserName = HttpContext.Session.GetString(SessionHelper.UserName);
            int vPageCount = Convert.ToInt32(_config.GetSection("AuditPageCount").Value);
            
            ViewBag.AuditMasterList = _repo.GetAuditMasters(new AuditMasterSearchDto()
            {
                IsCompleted = false
            }).ToPagedList(pPage ?? 1, vPageCount);
            vDashboardDto.AuditMasterCreationDto = vDto;
            if (pResp != null && pMesg != null)
            {
                vDashboardDto.ResponseType = ResponseType.Error;
                vDashboardDto.Message = pMesg;
            }
            return View(vDashboardDto);
        }

        [HttpPost]
        public IActionResult StartAudit(DashboardDto pDashboardDto)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            pDashboardDto.AuditMasterCreationDto.AuditDate = DateTime.Now;
            AuditMaster vAuditMaster = _repo.AddOrUpdateAuditMaster(pDashboardDto.AuditMasterCreationDto);
            if (vAuditMaster != null)
            {
                if (vAuditMaster.ResponseType == ResponseType.Error)
                {
                    return RedirectToAction("Dashboard", "Admin",
                        new { pResp = (int)vAuditMaster.ResponseType, pMesg = vAuditMaster.Message });
                }
            }
            return RedirectToAction("AuditSections", "Admin"
                , new { pAuditMasterId = vAuditMaster.AuditMasterID });
        }

        [HttpGet("AuditSections/{pAuditMasterId}")]
        public IActionResult AuditSections(int pAuditMasterId)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            HttpContext.Session.SetString(SessionHelper.AuditMasterId, pAuditMasterId.ToString());
            AuditSectionDto vAuditSectionDto = new();
            vAuditSectionDto.AuditMaster = _repo.GetAuditMasterById(pAuditMasterId);
            vAuditSectionDto.SectionList = _common.GetSections(pAuditMasterId);
            vAuditSectionDto.SectionCompletedCount = vAuditSectionDto.SectionList.Count(x => x.IsCompleted);
            vAuditSectionDto.TotalScore = _repo.GetSectionTracks(pAuditMasterId).Sum(x => x.SectionScore);
            return View(vAuditSectionDto);
        }

        public IActionResult AuditQuestions(int pSectionId)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            HttpContext.Session.SetString(SessionHelper.AuditSectionId, pSectionId.ToString());
            AuditDetailCreationDto vAuditQuestionDto = new();
            vAuditQuestionDto.QuestionList = _common.GetQuestionsBySectionId(pSectionId);
            vAuditQuestionDto.SectionName = _common.GetSectionNameById(pSectionId).SectionName;
            vAuditQuestionDto.MasterId = SessionHelper.GetCurrentAuditMasterId(HttpContext);
            vAuditQuestionDto.SectionId = pSectionId;

            var vSectionTrack = _repo.GetSectionTrack(vAuditQuestionDto.MasterId, pSectionId);
            if (vSectionTrack != null)
            {
                vAuditQuestionDto.IsCreateForm = false;
                var vSavedAuditQuestions = _repo.GetAuditDetails(vAuditQuestionDto.MasterId, pSectionId);
                for (int i = 0; i < vSavedAuditQuestions.Count; i++)
                {
                    vAuditQuestionDto.QuestionList[i].AuditDetailsID = vSavedAuditQuestions[i].AuditDetailsID;
                    vAuditQuestionDto.QuestionList[i].Comment = vSavedAuditQuestions[i].Comment;
                    vAuditQuestionDto.QuestionList[i].ResultDropdownId = vSavedAuditQuestions[i].Result;
                }
            }


            return View(vAuditQuestionDto);
        }

        [HttpPost]
        public IActionResult SaveAuditing(AuditDetailCreationDto pAuditQuestionDto)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            var vSectionTrack = _repo.GetSectionTrack(pAuditQuestionDto.MasterId, pAuditQuestionDto.SectionId);
            if (vSectionTrack != null)
            {
                pAuditQuestionDto.IsCreateForm = false;
            }
            else
            {
                pAuditQuestionDto.IsCreateForm = true;
            }
            int vAuditMasterId = Convert.ToInt32(HttpContext.Session.GetString(SessionHelper.AuditMasterId));


            AuditDetailCreationDto vAuditDetailCreationDto = _repo.AddOrUpdateAuditDetail(pAuditQuestionDto);
            return RedirectToAction("AuditSections", "Admin"
                , new { pAuditMasterId = vAuditMasterId });
        }

        public IActionResult AuditList(DateTime fromDate, DateTime toDate, string pSearchKey, int? pPage)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            int vPageCount = Convert.ToInt32(_config.GetSection("AuditPageCount").Value);
            var vAuditMasterList = _repo.GetAuditMasters(new AuditMasterSearchDto()
            {
                IsCompleted = true,
                FromDate = fromDate,
                ToDate = toDate,
                SearchText = pSearchKey
            });

            DashboardDto vDashboardDto = new DashboardDto();
            vDashboardDto.IsSearched = vAuditMasterList.Count == 0;
            if (vDashboardDto.IsSearched)
            {
                vAuditMasterList = _repo.GetAuditMasters(new AuditMasterSearchDto()
                {
                    IsCompleted = true
                });
            }

            ViewBag.AuditMasterList = vAuditMasterList.ToPagedList(pPage ?? 1, vPageCount);
            return View(vDashboardDto);
        }

        [HttpGet]
        public IActionResult ActivityLogs(int? pPage)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            DashboardDto vDashboardDto = new();
            ViewBag.Activities = _common.GetActivityLogs().ToPagedList(pPage ?? 1, 100);
            return View(vDashboardDto);
        }

        public IActionResult AuditReport(int pAuditMasterID)
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            ViewBag.AssuranceQuality = _repo.GetAuditDetailsReport(pAuditMasterID, 1);
            ViewBag.ControlAssurance = _repo.GetAuditDetailsReport(pAuditMasterID, 2);
            ViewBag.Consumables = _repo.GetAuditDetailsReport(pAuditMasterID, 3);
            ViewBag.Environment = _repo.GetAuditDetailsReport(pAuditMasterID, 4);
            ViewBag.Behaviour = _repo.GetAuditDetailsReport(pAuditMasterID, 5);
            ViewBag.MonitoringAssurance = _repo.GetAuditDetailsReport(pAuditMasterID, 6);
            ViewBag.WasteSegregation = _repo.GetAuditDetailsReport(pAuditMasterID, 7);
            AuditReportDto vAuditReportDto = new();
            vAuditReportDto.AuditMaster = _repo.GetAuditMasterById(pAuditMasterID);
            vAuditReportDto.IsVerified = vAuditReportDto.AuditMaster.VerifiedBy == null ? false : true;
            return View(vAuditReportDto);
        }

        public JsonResult VerifyAudit(VerifyAuditDto pVerifyAuditDto)
        {
            if (SessionHelper.IsLoggedIn(HttpContext))
            {
                if (string.IsNullOrEmpty(pVerifyAuditDto.VerifyComments))
                {
                    return Json(new { Message = "Verification Comment is required", HasError = true });
                }
                else if (string.IsNullOrEmpty(pVerifyAuditDto.VerifiedBy))
                {
                    return Json(new { Message = "Name is required", HasError = true });
                }
                else
                {
                    bool vIsSaved = _repo.VerifyAudit(pVerifyAuditDto);
                    return Json(new
                    {
                        Message = vIsSaved ? "Audit successfully verified" : "Error occurs while audit verifying",
                        HasError = false
                    });
                }
            }
            return Json(new { Message = "Your session was expired please login again.", HasError = true });
        }

        public IActionResult AllUsers()
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");

            var vAppUser = JsonConvert.DeserializeObject<AppUser>(HttpContext.Session.GetString(SessionHelper.AppUser));
            var vAppUsers = _common.GetAppUsers(vAppUser.SiteId);

            return View(vAppUsers);
        }
    }
}
