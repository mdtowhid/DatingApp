using Bees.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees.Shared.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string? Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        [Required]
        public string Password { get; set; }
        public bool? IsEmailConfirmed { get; set; }
        public string? Roles { get; set; }
        [Required(ErrorMessage = "Please select user type")]
        [Range(0, 5, ErrorMessage = "Please select user type")]
        public UserType UserType { get; set; }
        [NotMapped]
        public string? Message { get; set; }

    }
}
