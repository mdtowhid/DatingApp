using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeMaster.Models
{
    public class LkpRecipeCategory
    {
        public int Id { get; set; }
        public String CategoryName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
 
}


