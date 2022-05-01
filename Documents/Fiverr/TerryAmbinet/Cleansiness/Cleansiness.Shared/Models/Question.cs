using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestsID { get; set; }
        public int AspectID { get; set; }
        public int SectionID { get; set; }
        public int QuestNo { get; set; }
        public string QuestText { get; set; }
        public bool QuestStatus { get; set; }
        public bool QuestClean { get; set; }
        public DateTime UpdateDt { get; set; }
        [NotMapped]
        public string? Comment { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please select answere")]
        [Range(1,3, ErrorMessage = "Please select answere")]
        public int Answere { get; set; }
    }
}
