using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateWebApp.Shared.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
