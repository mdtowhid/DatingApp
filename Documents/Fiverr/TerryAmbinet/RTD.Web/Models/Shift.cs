using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTD.Web.Models
{
    [Table("shifttimes")]
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        public int ShiftType { get; set; }
        public string ShiftText { get; set; }
        public DateTime ShiftLastUpdate { get; set; }
    }
}