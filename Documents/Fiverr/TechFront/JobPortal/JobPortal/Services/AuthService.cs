using JobPortal.Models;
using JobPortal.Shared.DTO;
using JobPortal.Shared.Enums;
using JobPortal.Shared.Models;
using JobPortal.Shared.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace JobPortal.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public AuthService(IWebHostEnvironment env, AppDbContext context, IConfiguration config)
        {
            _env = env;
            _context = context;
            _config = config;
        }

        public async Task<ApiResponseDto<User>> ConfirmEmail(int pId)
        {
            var vIsExistUser = await _context.Users.FirstOrDefaultAsync(on => on.Id == pId);
            ApiResponseDto<User> vApiResponseDtoToReturn = new ApiResponseDto<User>
            {
                HasError = true,
                Message = $"Not Found",
                ResponseType = ResponseType.NotFound,

            };
            if (vIsExistUser == null)
            {
                return vApiResponseDtoToReturn;
            }
            else
            {
                vIsExistUser.IsActive = true;
                try
                {
                    _context.Users.Update(vIsExistUser);
                    await _context.SaveChangesAsync();
                    vApiResponseDtoToReturn.HasError = false;
                    vApiResponseDtoToReturn.Message = "Your account is confirmed. Please login";
                }
                catch (Exception ex)
                {
                    vApiResponseDtoToReturn.HasError = true;
                    vApiResponseDtoToReturn.Message = $"{ex.Message} \n {ex.InnerException.Message}";
                }

                return vApiResponseDtoToReturn;
            }
        }

        public async Task<ApiResponseDto<User>> GetUserById(int pId)
        {
            ApiResponseDto<User> vApiResponseDtoToReturn = new ApiResponseDto<User>
            {
                HasError = true,
                Message = $"Failed",
                ResponseType = ResponseType.Failed,
            };
            var vUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == pId);
            if(vUser != null)
            {
                vApiResponseDtoToReturn.ResponseType = ResponseType.Search;
                vApiResponseDtoToReturn.Result = vUser;
            }
            return vApiResponseDtoToReturn;
        }

        public async Task<AuthResponseDto> Login(UserForLoginDto pUserForLoginDto)
        {
            AuthResponseDto vApiResponseDtoToReturn = new AuthResponseDto();
            try
            {
                var vUser = await _context.Users.FirstOrDefaultAsync(on => on.Email == pUserForLoginDto.Email
                        && on.Password == ComputeHash(pUserForLoginDto.Password));

                if (vUser != null)
                {
                    vApiResponseDtoToReturn.User = vUser;
                    vApiResponseDtoToReturn.IsAuthSuccessful = true;
                }
                else
                {
                    vApiResponseDtoToReturn.Message = "Invalid log in.";
                    vApiResponseDtoToReturn.User = null;
                    vApiResponseDtoToReturn.IsAuthSuccessful = false;
                }
            }
            catch (Exception ex)
            {
                vApiResponseDtoToReturn.Message = ex.Message;
                vApiResponseDtoToReturn.User = null;
                vApiResponseDtoToReturn.IsAuthSuccessful = false;
            }

            return vApiResponseDtoToReturn;
        }

        public async Task<ApiResponseDto<User>> Register(UserForCreationDto pUserForCreationDto)
        {
            var vIsExistUser = await _context.Users.FirstOrDefaultAsync(on => on.Email == pUserForCreationDto.Email);
            ApiResponseDto<User> vApiResponseDtoToReturn = new ApiResponseDto<User>
            {
                HasError=true,
                Message = $"Failed",
                ResponseType = ResponseType.Failed,

            };

            if (vIsExistUser != null)
            {
                vApiResponseDtoToReturn.Message = $"User already exist with email {pUserForCreationDto.Email}";
                return vApiResponseDtoToReturn;
            }

            try
            {
                pUserForCreationDto.Password = ComputeHash(pUserForCreationDto.Password);
                Employer vEmployer = new Employer()
                {
                    CompanyName = pUserForCreationDto.CompanyName,
                    CreatedAt = DateTime.Now,
                    RegionId = null,
                    CityId = null
                };
                await _context.Employers.AddAsync(vEmployer);
                bool isSaved = await _context.SaveChangesAsync() > 0;

                if (isSaved)
                {
                    UserType vUserType = await _context.UserTypes.FirstOrDefaultAsync(on => on.UserTypeName == "Employer");
                    User vUser = new User()
                    {
                        FirstName = pUserForCreationDto.FirstName,
                        LastName = pUserForCreationDto.LastName,
                        Email = pUserForCreationDto.Email,
                        Password = pUserForCreationDto.Password,
                        CreatedAt = DateTime.Now,
                        EmployerId = vEmployer.Id,
                        CityId = null,
                        RegionId = null,
                        UserTypeId = vUserType.Id,
                        IsActive = false,
                    };

                    _context.Users.Add(vUser);
                    isSaved = await _context.SaveChangesAsync() > 0;
                    string url = _config.GetSection("MailSettings:ConfirmEmailUrl").Value.ToString();
                    BuildEmailTemplate(url, vUser);
                    vApiResponseDtoToReturn.HasError = false;
                    vApiResponseDtoToReturn.Message = "A confirmation email is sent to your mail account. Please confirm.";
                }
            }
            catch (Exception ex)
            {
                vApiResponseDtoToReturn.HasError = true;
                vApiResponseDtoToReturn.Message=$"{ex.Message} \n {ex.InnerException.Message}";
            }

            return vApiResponseDtoToReturn;
        }


        #region SendingEmail

        async void BuildEmailTemplate(string url, User registeredUser)
        {
            string body = File.ReadAllText(_env.ContentRootPath + "/wwwroot/EmailTemplate.html");
            var regInfo = registeredUser;
            url = url + registeredUser.Id;
            body = body.Replace("ConfirmationLink", url);
            body = body.Replace("regUser", "Welcome! " + regInfo.FirstName);
            body = body.ToString();
            BuildEmailTemplate("Your Account is successfully created.", body, regInfo.Email);
        }
        void BuildEmailTemplate(string subjectText, string bodyText, string sendTo)
        {
            string appMail = _config.GetSection("MailSettings:AppEmail").Value.ToString();
            string from, to, bcc, cc, subject, body;
            from = appMail;
            to = sendTo.Trim();
            bcc = "";
            cc = "";
            subject = subjectText;
            StringBuilder sb = new StringBuilder();
            sb.Append(bodyText);
            body = sb.ToString();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            if (!string.IsNullOrEmpty(bcc))
            {
                mail.Bcc.Add(new MailAddress(bcc));
            }

            if (!string.IsNullOrEmpty(cc))
            {
                mail.Bcc.Add(bcc);
            }

            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            SendEmail(mail);
        }
        void SendEmail(MailMessage mail)
        {
            string appMail = _config.GetSection("MailSettings:AppEmail").Value.ToString();
            string appMailPassword = _config.GetSection("MailSettings:Password").Value.ToString();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(appMail, appMailPassword);

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ApiResponseDto<User>> SendRecoveryEmail(string pEmail)
        {
            var vApiResponseDtoToReturn = new ApiResponseDto<User>()
            {
                Message = $"No account found with {pEmail}",
                ResponseType = ResponseType.Failed
            };
            var registeredUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == pEmail);
            if (registeredUser == null) return vApiResponseDtoToReturn;

            if (await SendRecoveryEmail(registeredUser))
            {
                vApiResponseDtoToReturn.Message = "Recovery email has been sent to your mail account.";
                vApiResponseDtoToReturn.ResponseType = ResponseType.SendingEmail;
                return vApiResponseDtoToReturn;
            }

            return vApiResponseDtoToReturn;
        }

        private Task<bool> SendRecoveryEmail(User registeredUser)
        {
            bool vIsSentEmail = false;
            try
            {
                string body = File.ReadAllText(_env.ContentRootPath + "/wwwroot/RecoverEmailTemplate.html");
                var regInfo = registeredUser;
                string url = _config.GetSection("MailSettings:RecoverAccountUrl").Value.ToString() + registeredUser.Id;
                body = body.Replace("RecoverAccountUrl", url);
                body = body.Replace("regUser", "Welcome! " + registeredUser.FirstName);
                body = body.ToString();
                BuildEmailTemplate("Forgot your password? We can help.", body, registeredUser.Email);
                vIsSentEmail = true;
            }
            catch (Exception ex)
            {
                vIsSentEmail = false;
            }

            return Task.FromResult(vIsSentEmail);
        }

        #endregion

        static string ComputeHash(string pPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pPassword));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public async Task<ApiResponseDto<User>> ForgotPassword(string pEmail)
        {
            ApiResponseDto<User> vApiResponseDtoToReturn = new ApiResponseDto<User>
            {
                Message = $"Failed",
                ResponseType = ResponseType.Failed,
            };

            try
            {
                var vIsExistUser = await _context.Users.FirstOrDefaultAsync(on => on.Email == pEmail);
                if (vIsExistUser != null)
                {
                    vApiResponseDtoToReturn.Message = @"Check your email. <br> We just sent an email to you with a link to reset your password!";
                    vApiResponseDtoToReturn.Result = vIsExistUser;
                    vApiResponseDtoToReturn.ResponseType = ResponseType.SendingEmail;
                    await SendRecoveryEmail(pEmail);
                }
                else
                {
                    vApiResponseDtoToReturn.Message = $"No account found with id {pEmail}";
                }
            }
            catch (Exception ex)
            {
                vApiResponseDtoToReturn.Message = $"{ex.Message}";
            }
            
            return vApiResponseDtoToReturn;
        }

        public async Task<ApiResponseDto<RecoverAccountDto>> RecoverAccount(RecoverAccountDto pForgotPasswordDto)
        {
            var vApiResponseDtoToReturn = new ApiResponseDto<RecoverAccountDto>()
            {
                Message = $"No account found.",
                ResponseType = ResponseType.Failed
            };

            try
            {
                var vRegisteredUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == pForgotPasswordDto.Id);
                if (vRegisteredUser == null) return vApiResponseDtoToReturn;

                vRegisteredUser.Password = ComputeHash(pForgotPasswordDto.Password);
                _context.Users.Update(vRegisteredUser);
                bool vIsUpdated = await _context.SaveChangesAsync() > 0;
                if (vIsUpdated)
                {
                    vApiResponseDtoToReturn.Message = "Account recovered successfully.Please login ";
                    vApiResponseDtoToReturn.ResponseType = ResponseType.Update;
                    vApiResponseDtoToReturn.Result = null;
                }
            }
            catch (Exception ex)
            {
                vApiResponseDtoToReturn.Message = $"Exception! {ex.Message}";
            }
            return vApiResponseDtoToReturn;
        }
    }
}
