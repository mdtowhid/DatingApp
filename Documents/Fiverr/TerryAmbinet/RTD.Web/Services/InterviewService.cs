using RTD.Web.Models;
using RTD.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTD.Web.Services
{
    public class InterviewService : IInterviewRepository
    {
        private readonly AppDbContext _context;

        public InterviewService(AppDbContext context)
        {
            _context = context;
        }
        public Interview GetInterview(int? pInterviewId)
        {
            return _context.Interviews.FirstOrDefault(x => x.InterviewId == pInterviewId);
        }

        public List<Interview> GetInterviews()
        {
            return _context.Interviews.ToList();
        }

        public Interview SaveAbsenceDetail(Interview pInterview)
        {
            Interview vInterview = new();
            try
            {
                if(pInterview.InterviewId == 0)
                {
                    _context.Interviews.Add(pInterview);
                }
                else
                {
                    _context.Interviews.Update(pInterview);
                }
                vInterview.IsSaved = _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                vInterview.Message = ex.Message;
            }
            return vInterview;
        }

        public ActivityLog SaveActivityLog(Interview pInterview, ActivityLog pActivityLog)
        {
            throw new NotImplementedException();
        }

        public Interview SavePersonalDetail(Interview pInterview)
        {
            throw new NotImplementedException();
        }

        public Interview SaveProcedureDetail(Interview pInterview)
        {
            throw new NotImplementedException();
        }

        public Interview SaveRecoveryDetail(Interview pInterview)
        {
            throw new NotImplementedException();
        }

        public Interview SaveSubmitForm(Interview pInterview)
        {
            throw new NotImplementedException();
        }

        public Interview SaveSummaryDetail(Interview pInterview)
        {
            throw new NotImplementedException();
        }

        public Interview SaveTrainingAndAppraisal(Interview pInterview)
        {
            throw new NotImplementedException();
        }
    }
}
