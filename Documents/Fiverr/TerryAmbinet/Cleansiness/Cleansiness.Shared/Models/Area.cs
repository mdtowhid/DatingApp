﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cleansiness.Shared.Models
{
    [Table("Areas")]
    public class Area
    {
        [Key]
        public int AreaID { get; set; }
        public int SiteID { get; set; }
        public int DivID { get; set; }
        public int RiskID { get; set; }
        public string AreaName { get; set; }
        public bool AreaStatus { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
