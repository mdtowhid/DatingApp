using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CertificateWebApp.Shared.Interfaces;
using CertificateWebApp.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace CertificateWebApp.Client.Pages.Account
{
    public class LoginBase : ComponentBase
    {
        public User _userForAuthentication = new User();
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public bool ShowAuthError { get; set; }
        public string Error { get; set; }
        public async Task ExecuteLogin()
        {
            ShowAuthError = false;
            var result = await AuthenticationService.Login(_userForAuthentication);
            if (!result.IsAuthSuccessful)
            {
                Error = result.ErrorMessage;
                ShowAuthError = true;
                NavigationManager.NavigateTo("/account/login");
            }
            else
            {
                NavigationManager.NavigateTo("/admin/home", true);
            }
        }
    }
}
