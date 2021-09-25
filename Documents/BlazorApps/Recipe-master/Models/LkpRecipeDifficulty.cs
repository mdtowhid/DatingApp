using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeMaster.Models
{
    public class LkpRecipeDifficulty
    {
        public int Id { get; set; }
        public String Difficulty { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
