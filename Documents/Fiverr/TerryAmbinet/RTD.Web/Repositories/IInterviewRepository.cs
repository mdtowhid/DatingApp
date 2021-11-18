using RTD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTD.Web.Repositories
{
    public interface IInterviewRepository
    {
        List<Interview> GetInterviews();
        Interview GetInterview(int? pInterviewId);
        Interview SaveAbsenceDetail(Interview pInterview);
        Interview SavePersonalDetail(Interview pInterview);
        Interview SaveProcedureDetail(Interview pInterview);
        Interview SaveRecoveryDetail(Interview pInterview);
        Interview SaveSummaryDetail(Interview pInterview);
        Interview SaveTrainingAndAppraisal(Interview pInterview);
        Interview SaveSubmitForm(Interview pInterview);
        ActivityLog SaveActivityLog(Interview pInterview, ActivityLog pActivityLog);
    }
}
