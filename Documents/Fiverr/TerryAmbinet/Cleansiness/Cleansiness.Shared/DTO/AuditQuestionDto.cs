using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class AuditQuestionDto
    {
        public List<Question> QuestionList { get; set; }
        public string SectionName { get; set; }
        public int AuditMasterId { get; set; }
        //public List<ResultDto> ResultDtoList { get; set; } = new();
        //public AuditQuestionDto()
        //{
        //    ResultDtoList.Add(new ResultDto() { Id = 1, Text = "", Value = 1 });
        //}
    }
}
