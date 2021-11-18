using RTD.Web.Models;
using RTD.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTD.Web.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }
        public AppUser LogIn(AppUser pAppUser)
        {
            AppUser vAppUser = _context.AppUsers.FirstOrDefault(x => x.UserEmail == pAppUser.UserEmail && x.UserPw == pAppUser.UserPw);

            if (vAppUser != null)
            {
                vAppUser.IsLoggedIn = true;
            }
            return vAppUser;
        }

        public AppUser Register(AppUser pAppUser)
        {
            throw new NotImplementedException();
        }
    }
}
