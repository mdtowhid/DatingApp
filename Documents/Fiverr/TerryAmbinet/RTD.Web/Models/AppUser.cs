using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTD.Web.Models
{
    [Table("appuser")]
    public class AppUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserfName { get; set; }
        public string UsersName { get; set; }
        public string UserEmail { get; set; }
        public string UserPw { get; set; }
        public int UserType { get; set; }
        public bool UserStatus { get; set; }
        public DateTime UserLastUpdate { get; set; }

        [NotMapped]
        public bool IsLoggedIn { get; set; }
    }
}
