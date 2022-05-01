using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Shared.Models
{
    [Table("Employer")]
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string CompanyName { get; set; }
        [Required]
        public string Description { get; set; }
        [StringLength(30)]
        [Required]
        public string Phone { get; set; }
        [Required]
        public int? RegionId { get; set; }
        public virtual Region? Region { get; set; }
        [Required]
        public int? CityId { get; set; }
        public virtual City? City { get; set; }
        [StringLength(80)]
        public string Website { get; set; }
        [Required]
        [StringLength(80)]
        public string Logo { get; set; }
        [StringLength(80)]
        public string VideoUrl { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
