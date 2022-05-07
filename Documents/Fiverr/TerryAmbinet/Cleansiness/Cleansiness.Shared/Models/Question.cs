using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cleansiness.Shared.DTO;

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
        public int ResultDropdownId { get; set; }
        [NotMapped]
        public List<ResultDropdown> ResultDropdowns { get; set; }
        [NotMapped]
        public int AuditDetailsID { get; set; }
        public Question()
        {
            ResultDropdowns = new List<ResultDropdown>()
            {
                new ResultDropdown{Id=1, Text="YES", Value=1},
                new ResultDropdown{Id=1, Text="NO", Value=2},
                new ResultDropdown{Id=1, Text="NA", Value=3},
            };
        }
    }
}
