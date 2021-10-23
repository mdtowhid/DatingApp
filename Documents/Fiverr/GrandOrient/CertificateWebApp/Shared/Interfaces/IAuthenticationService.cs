using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertificateWebApp.Shared.Models;

namespace CertificateWebApp.Shared.Interfaces
{
    public interface IAuthenticationService
    {
        //Task<User> RegisterUser(User user);
        Task<AuthResponseDto> Login(User user);
        Task Logout();
    }
}
