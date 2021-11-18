using RTD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTD.Web.Repositories
{
    public interface IAuthRepository
    {
        AppUser LogIn(AppUser pAppUser);
        AppUser Register(AppUser pAppUser);
    }
}
