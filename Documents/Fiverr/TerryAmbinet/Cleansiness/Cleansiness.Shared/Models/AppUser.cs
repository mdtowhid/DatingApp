using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("AppUser")]
    public class AppUser
    {
        [Key]
        public int UserId { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public bool UserStatus { get; set; }
        public DateTime? UpdateDt { get; set; }

        [NotMapped]
        public bool IsLoggedIn { get; set; }
    }
}
