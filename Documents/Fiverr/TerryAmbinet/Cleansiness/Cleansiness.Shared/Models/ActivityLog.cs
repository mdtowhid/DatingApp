using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("activity")]
    public class ActivityLog
    {
        [Key]
        public int ActivityId { get; set; }
        public int ActNo { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser? AppUser { get; set; }
        public string ActAction { get; set; }
        public DateTime ActDate { get; set; }
        [NotMapped]
        public string AppUserFullName { get; set; }
    }
}