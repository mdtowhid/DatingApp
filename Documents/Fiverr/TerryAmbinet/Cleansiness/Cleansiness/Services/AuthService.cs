using Cleansiness.Models;
using Cleansiness.Shared.Interfaces;
using Cleansiness.Shared.Models;

namespace Cleansiness.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }
        public AppUser Login(string pEmail, string pPassword)
        {
            AppUser vAppUser = _context.AppUsers.FirstOrDefault(x => x.Email == pEmail && x.Password == pPassword);

            if (vAppUser != null)
            {
                vAppUser.IsLoggedIn = true;
                return vAppUser;
            }
            return new AppUser();
        }

        public AppUser Register(AppUser pAppUser)
        {
            throw new NotImplementedException();
        }
    }
}
