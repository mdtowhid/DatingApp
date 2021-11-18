using System;
using System.ComponentModel.DataAnnotations;

namespace RTD.Web.Models
{
    public class ActivityLog
    {
        [Key]
        public int ActivityId { get; set; }
        public DateTime ActDate { get; set; }
        public string ActMsg { get; set; }
        public int UserId { get; set; }
        public int SectId { get; set; }

    }
}