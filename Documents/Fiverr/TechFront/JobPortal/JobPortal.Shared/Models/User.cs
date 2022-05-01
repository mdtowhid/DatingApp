using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string? FirstName { get; set; }
        [StringLength(30)]
        public string? LastName { get; set; }
        [Required]
        [StringLength(80)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(30)]
        public string? Phone { get; set; }
        [Required]
        [StringLength(250)]
        public string Password { get; set; }
        public int? RegionId { get; set; }
        public virtual Region? Region { get; set; }
        public int? CityId { get; set; }
        public virtual City? City { get; set; }
        public int? UserTypeId { get; set; }
        public virtual UserType? UserType { get; set; }
        public int? EmployerId { get; set; }
        public virtual Employer? Employer { get; set; }
        public bool? IsTermsAgree { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
