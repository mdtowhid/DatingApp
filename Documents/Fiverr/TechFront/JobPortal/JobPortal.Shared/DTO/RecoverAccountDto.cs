using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.DTO
{
    public class RecoverAccountDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Compare("Password")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public bool? ForSendingRecoveryEmail { get; set; }
    }
}
