using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.Models
{
    [Table("Region")]
    public class Region
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RegionName { get; set; }
    }
}
