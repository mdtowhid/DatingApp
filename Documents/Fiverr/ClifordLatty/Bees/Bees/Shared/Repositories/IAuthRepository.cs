using Bees.Shared.DTO;
using Bees.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.Shared.Repositories
{
    public interface IAuthRepository
    {
        Task<AuthResponseDto> Login(UserForLoginDto pUserForLoginDto);

        Task<User> Register(User user);
        Task<bool> UserExists(string id);
        Task<User> GetUserById(string id);
        Task<User> ConfirmEmail(string id);
    }
}
