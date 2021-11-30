using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reddocoin.Models
{
    public class Chart
    {
        [Key]
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        [Timestamp]
        public byte[] TS { get; set; }
    }
}
