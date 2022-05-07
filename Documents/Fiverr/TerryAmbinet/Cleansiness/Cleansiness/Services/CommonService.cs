using Cleansiness.Models;
using Cleansiness.Shared.DTO;
using Cleansiness.Shared.Interfaces;
using Cleansiness.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Cleansiness.Services
{
    public class CommonService : ICommonRepository
    {
        private readonly AppDbContext _context;

        public CommonService(AppDbContext context)
        {
            _context = context;
        }
        public List<ActivityLog> GetActivityLogs()
        {
            return _context.ActivityLogs.Include(x => x.AppUser).OrderByDescending(x => x.ActDate).ToList();
        }

        public List<AppUser> GetAppUsers()
        {
            return _context.AppUsers.OrderByDescending(x => x.UserName).ToList();
        }

        public List<Area> GetAreas()
        {
            return _context.Areas.ToList();
        }

        public List<Aspect> GetAspects()
        {
            return _context.Aspects.ToList();
        }

        public List<Division> GetDivisions()
        {
            return _context.Divisions.ToList();
        }

        public List<Question> GetQuestions()
        {
            return _context.Questions.ToList();
        }

        public List<Question> GetQuestionsBySectionId(int pSectionId)
        {
            return _context.Questions.Where(x=>x.SectionID == pSectionId).ToList();
        }

        public List<ResultDto> GetResultDtos()
        {
            return new List<ResultDto>()
            {
                new ResultDto{Id=1, Text="YES", Value=1},
                new ResultDto{Id=1, Text="NO", Value=2},
                new ResultDto{Id=1, Text="NA", Value=3},
            };
        }

        public List<Risk> GetRisks()
        {
            return _context.Risks.ToList();
        }

        public Section GetSectionNameById(int pSectionId)
        {
            return _context.Sections.FirstOrDefault(x => x.SectionID == pSectionId);
        }

        public List<Section> GetSections(int pMasterId)
        {
            List<Section> vSections = _context.Sections.ToList();
            var vSectionTracks = _context.SectionTracks.Where(x => x.AuditMasterID == pMasterId).ToList();
            for (int i = 0; i < vSectionTracks.Count; i++)
            {
                var vSection = vSections.FirstOrDefault(x => x.SectionID == vSectionTracks[i].SectionID);
                if (vSection != null)
                {
                    vSection.IsCompleted = true;
                }
            }
            return vSections;
        }

        public List<Site> GetSites()
        {
            return _context.Sites.ToList();
        }

        public void LogUserActivity(AppUser pAppUser, int pActivityType)
        {
            string vActMesg = "";
            if (pActivityType == 1)
            {
                vActMesg = $"{pAppUser.Name} is logged in.";
            }
            else
            {
                vActMesg = $"{pAppUser.Name} is logged out.";
            }
            _context.ActivityLogs.Add(new ActivityLog
            {
                ActDate = DateTime.Now,
                ActAction = vActMesg,
                ActNo = 0,
                AppUserId = pAppUser.UserId,
            });
            bool isSaved = _context.SaveChanges() > 0;
        }
    }
}
