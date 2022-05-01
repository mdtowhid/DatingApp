using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("Sites")]
    public class Site
    {
        [Key]
        public int SiteID { get; set; }
        public string SiteName { get; set; }
        public DateTime UpdateDt { get; set; }

    }
}
