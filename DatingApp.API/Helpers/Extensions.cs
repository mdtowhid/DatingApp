using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse http, string message)
        {
            http.Headers.Add("Apllication-Error", message);
            http.Headers.Add("Access-Control-Expose-Headers", "Apllication-Error");
            http.Headers.Add("Access-Control-Allow-Origin", "*");

        }
        public static int CalculateAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;

            if (theDateTime.AddYears(age) > DateTime.Today)
            {
                age--;
            }

            return age;
        }
    }
}