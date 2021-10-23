using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CertificateWebApp.Server.Entities;
using CertificateWebApp.Shared.Interfaces;
using CertificateWebApp.Shared.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CertificateWebApp.Server.Services
{
    public class AuthenticationService : IUserRepository
    {
        private readonly CertificateWebAppDbContext _context;

        public AuthenticationService(CertificateWebAppDbContext context)
        {
            _context = context;
        }

        public async Task<User> Login(User user)
        {
            return await _context.Users.FirstOrDefaultAsync(
                x => x.Email == user.Email && x.Password == user.Password);
        }

        public Task<User> SaveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
