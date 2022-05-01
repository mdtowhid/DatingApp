using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Models
{
    [Table("Aspects")]
    public class Aspect
    {
        [Key]
        public int AspectID { get; set; }
        public string AspectName { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
