using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTD.Web.Models
{
    [Table("sicknessreason")]
    public class Sickness
    {
        [Key]
        public int SicknessId { get; set; }
        public string SicknessReason { get; set; }
        public DateTime SicknessLastUpdate { get; set; }

    }
}
