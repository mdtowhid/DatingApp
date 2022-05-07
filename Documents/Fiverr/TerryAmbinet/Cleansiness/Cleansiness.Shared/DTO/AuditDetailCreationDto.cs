using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class AuditDetailCreationDto : ModelBase
    {
        public int AuditDetailsID { get; set; }
        public List<Question> QuestionList { get; set; }
        public string SectionName { get; set; }
        public int MasterId { get; set; }
        public int SectionId { get; set; }
        //public int SectionStatus { get; set; }
        public bool IsCreateForm { get; set; }
    }
}
