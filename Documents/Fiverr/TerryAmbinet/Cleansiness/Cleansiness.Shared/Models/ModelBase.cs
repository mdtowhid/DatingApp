using Cleansiness.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.Models
{
    public class ModelBase
    {
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public ResponseType ResponseType { get; set; }
    }
}
