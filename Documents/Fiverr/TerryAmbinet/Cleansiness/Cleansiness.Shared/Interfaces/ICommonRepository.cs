﻿using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Interfaces
{
    public interface ICommonRepository
    {
        List<Question> GetQuestionsBySectionId(int pSectionId);
        List<Question> GetQuestions();
        List<Division> GetDivisions();
        List<Aspect> GetAspects();
        List<Risk> GetRisks();
        List<Section> GetSections();
        Section GetSectionNameById(int pSectionId);
        List<Site> GetSites();
        List<Area> GetAreas();
        List<ActivityLog> GetActivityLogs();
        void LogUserActivity(AppUser pAppUser, int pActivityType);
    }
}