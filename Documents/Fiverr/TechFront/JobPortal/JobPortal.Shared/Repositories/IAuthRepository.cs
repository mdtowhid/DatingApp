using JobPortal.Shared.DTO;
using JobPortal.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.Repositories
{
    public interface IAuthRepository
    {
        Task<AuthResponseDto> Login(UserForLoginDto pUserForLoginDto);
        Task<ApiResponseDto<User>> Register(UserForCreationDto pUserForCreationDto);
        Task<ApiResponseDto<User>> GetUserById(int pId);
        Task<ApiResponseDto<User>> ConfirmEmail(int id);

        Task<ApiResponseDto<User>> ForgotPassword(string pEmail);
        Task<ApiResponseDto<User>> SendRecoveryEmail(string pEmail);
        Task<ApiResponseDto<RecoverAccountDto>> RecoverAccount(RecoverAccountDto pRecoverAccountDto);
    }
}
