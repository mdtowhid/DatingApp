using JobPortal.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.DTO
{
    public class UserForCreationDto
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(80)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(250)]
        public string Password { get; set; }
    }
}
