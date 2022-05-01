using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Models
{
    [Table("Risks")]
    public class Risk
    {
        [Key]
        public int RiskID { get; set; }
        public string Riskname { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
