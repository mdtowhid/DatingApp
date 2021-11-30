using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddocoin.Models
{
    public class ReddocoinValue
    {
        public Guid Id { get; set; }
        public decimal RValues { get; set; }
        public decimal Holders { get; set; }
        public decimal Circulating { get; set; }
        public decimal MarketCaps { get; set; }
    }
}
