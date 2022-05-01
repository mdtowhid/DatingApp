using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Interfaces
{
    public interface IAuthRepository
    {
        AppUser Login(string pEmail, string pPassword);
        AppUser Register(AppUser pAppUser);
    }
}
