using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("Areas")]
    public class Area
    {
        [Key]
        public int AreaID { get; set; }
        public int SiteID { get; set; }

        [ForeignKey("Division")]
        public int DivID { get; set; }
        public virtual Division? Division { get; set; }
        [ForeignKey("Risk")]
        public int RiskID { get; set; }
        public virtual Risk? Risk { get; set; }
        public string AreaName { get; set; }
        public bool AreaStatus { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
