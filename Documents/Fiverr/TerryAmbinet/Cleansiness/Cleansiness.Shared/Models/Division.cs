using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Models
{
    [Table("Divisions")]
    public class Division
    {
        [Key]
        public int DivID { get; set; }
        public string DivName { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
