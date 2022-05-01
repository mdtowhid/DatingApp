using JobPortal.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.DTO
{
    public class ApiResponseDto<T> where T : class, new()
    {
        public List<T> Results { get; set; } = new();
        public T Result { get; set; } = new();
        public string Message { get; set; }
        public bool RowEffected { get; set; }
        public ResponseType ResponseType { get; set; }
        public bool HasError { get; set; }
        public string ViewData { get; set; }
    }
}
