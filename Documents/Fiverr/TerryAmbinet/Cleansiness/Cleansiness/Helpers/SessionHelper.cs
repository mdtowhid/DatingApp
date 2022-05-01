using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cleansiness.Helpers
{
    public static class SessionHelper
    {
        public static string UserId { get; } = "UserId";
        public static string UserEmail { get; } = "UserEmail";
        public static string UserType { get; } = "UserType";
        public static string AppUser { get; } = "AppUser";
        public static string CurrentInterviewId { get; } = "CurrentInterviewId";
        public static string AuditMasterId { get; } = "AuditMasterId";
        public static string AuditSectionId { get; } = "AuditSectionId";


        public static bool IsLoggedIn(HttpContext httpContext)
        {
            return !string.IsNullOrEmpty(httpContext.Session.GetString(UserId));
        }

        public static int GetUserId(HttpContext httpContext)
        {
            return Convert.ToInt32(httpContext.Session.GetString(UserId));
        }

        public static int GetUserType(HttpContext httpContext)
        {
            return Convert.ToInt32(httpContext.Session.GetString(UserType));
        }

        public static int GetCurrentAuditMasterId(HttpContext httpContext)
        {
            return Convert.ToInt32(httpContext.Session.GetString(AuditMasterId));
        }

        public static int GetCurrentSectionId(HttpContext httpContext)
        {
            return Convert.ToInt32(httpContext.Session.GetString(AuditSectionId));
        }

        public static void DestroySession(HttpContext httpContext)
        {
            httpContext.Session.SetString(UserId, string.Empty);
            httpContext.Session.SetString(UserEmail, string.Empty);
        }

    }
}
