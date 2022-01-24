using Bees.Server.Models;
using Bees.Shared.DTO;
using Bees.Shared.Models;
using Bees.Shared.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace Bees.Server.Services
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


        public async Task<User> ConfirmEmail(string id)
        {
            var vUser = await GetUserById(id);
            if (vUser != null)
            {
                vUser.IsEmailConfirmed = true;
                _context.Users.Update(vUser);
                bool isUpdated = await _context.SaveChangesAsync() > 0;
                if (isUpdated)
                {
                    vUser.Password = "";
                    vUser.Message = "Your account is confirmed.";
                }
            }
            return vUser;
        }

        public async Task<User> GetUserById(string id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<AuthResponseDto> Login(UserForLoginDto pUserForLoginDto)
        {
            var vUser = await _context.Users
                   .FirstOrDefaultAsync(x => x.Email == pUserForLoginDto.Email 
                   && x.Password == pUserForLoginDto.Password && x.UserType == pUserForLoginDto.UserType);
            AuthResponseDto authResponseDto = new();
            if (vUser == null)
                return authResponseDto;

            authResponseDto.IsAuthSuccessful = true;
            authResponseDto.User = vUser;

            return authResponseDto;
        }

        public async Task<User> Register(User user)
        {
            user.Password = ComputeHash(user.Password);
            user.CreatedAt = DateTime.Now;
            user.Id = Guid.NewGuid().ToString();
            string vOut = string.Empty;

            _context.Users.Add(user);
            bool isSaved = await _context.SaveChangesAsync() > 0;

            if (isSaved)
            {
                user.Password = "";
                user.Message = "A confirmation email is sent to your mail account. Please confirm.";
                string url = _config.GetSection("MailSettings:ConfirmEmailUrl").Value.ToString();
                BuildEmailTemplate(url, user);
            }

            return user;
        }

        public Task<bool> UserExists(string id)
        {
            throw new NotImplementedException();
        }




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



        async void BuildEmailTemplate(string url, User registeredUser)
        {
            string body = File.ReadAllText(_env.ContentRootPath + "/wwwroot/EmailTemplate.html");
            var regInfo = registeredUser;
            url = url + registeredUser.Id;
            body = body.Replace("ConfirmationLink", url);
            body = body.Replace("regUser", "Welcome! " + regInfo.UserName);
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
    }
}
