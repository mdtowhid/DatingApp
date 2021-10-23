using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertificateWebApp.Shared.Models;

namespace CertificateWebApp.Shared.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Login(User user);
        Task<User> SaveUser(User user);
    }
}
