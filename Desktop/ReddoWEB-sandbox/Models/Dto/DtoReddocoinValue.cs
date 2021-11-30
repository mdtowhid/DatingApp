using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddocoin.Models.Dto
{
    public class DtoReddocoinValue
    {
        public decimal RValues { get; set; }
        public decimal Holders { get; set; }
        public decimal Circulating { get; set; }
        public decimal MarketCaps { get; set; }
    }
}
