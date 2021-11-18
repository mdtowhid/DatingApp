using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTD.Web.Models
{
    [Table("jobtitle")]
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }
        public string JobTilte { get; set; }
        public DateTime JobLastUpdate { get; set; }
    }
}
