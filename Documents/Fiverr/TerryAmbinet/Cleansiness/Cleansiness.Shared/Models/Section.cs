using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("Sections")]
    public class Section
    {
        [Key]
        public int SectionID { get; set; }
        public int SectionOrder { get; set; }
        public string SectionName { get; set; }
        public bool SectionActive { get; set; }
        public DateTime UpdateDt { get; set; }

    }
}
