using JobPortal.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.DTO
{
    public class AuthResponseDto
    {
        public string Message { get; set; }
        public User User { get; set; } = new();
        public bool IsAuthSuccessful { get; set; }
    }
}
