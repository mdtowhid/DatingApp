using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RTD.Web.Models;
using RTD.Web.Repositories;
using System.Linq;

namespace RTD.Web.Controllers
{
    public class RtdAdminController : Controller
    {
        private readonly IInterviewRepository _repo;

        public RtdAdminController(IInterviewRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SaveAbsenceDetail(int? pInterviewId)
        {
            if (pInterviewId != null)
            {
                Interview vInterview = _repo.GetInterview(pInterviewId);
                return View(vInterview);
            }
            return View();
        }
        [HttpPost]
        public IActionResult SaveAbsenceDetail(Interview pInterview)
        {
            Interview vInterview = _repo.SaveAbsenceDetail(pInterview);
            //if(pInterview.InterviewId == 0)
            //{
            //    var vInterviews = _repo.GetInterviews();
            //    if (vInterviews.Any())
            //    {
            //        int vMaxInterviewId = vInterviews.Max(x=>x.InterviewId);
            //        pInterview.InterviewId=vMaxInterviewId + 1;
            //    }
            //    else
            //    {
            //        pInterview.InterviewId += 1;
            //    }
            //}

            //if (ModelState.IsValid)
            //{
            //    Interview vInterview = _repo.SaveAbsenceDetail(pInterview);
            //}
            //else
            //{
            //    foreach (var (k, v) in ModelState.Where(x => x.Value.ValidationState == ModelValidationState.Invalid))
            //    {
            //        v.Errors.Clear();
            //        v.Errors.Add("This Input is not valid.");
            //    }
            //}
            return View();
        }

        [HttpGet]
        public IActionResult SavePersonalDetail(int? pInterviewId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult SavePersonalDetail(Interview pInterview)
        {
            return View();
        }



        [HttpGet]
        public IActionResult SaveProcedureDetail(int? pInterviewId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveProcedureDetail(Interview pInterview)
        {
            return View();
        }



        [HttpGet]
        public IActionResult SaveRecovery(int? pInterviewId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveRecovery(Interview pInterview)
        {
            return View();
        }



        [HttpGet]
        public IActionResult SaveSummary(int? pInterviewId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveSummary(Interview pInterview)
        {
            return View();
        }



        [HttpGet]
        public IActionResult SaveTrainingAndAppraisal(int? pInterviewId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveTrainingAndAppraisal(Interview pInterview)
        {
            return View();
        }



        [HttpGet]
        public IActionResult SaveForm(int? pInterviewId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveForm(Interview pInterview)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Activity()
        {
            return View();
        }

        private void IterateModelStateErrorErrors(ModelStateDictionary keyValuePairs)
        {

        }
    }
}
