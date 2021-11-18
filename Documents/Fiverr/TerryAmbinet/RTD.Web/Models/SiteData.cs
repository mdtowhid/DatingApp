using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTD.Web.Models
{
    [Table("sitedata")]
    public class SiteData
    {
        [Key]
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteAdmin { get; set; }
        public string SiteAdminEmail1 { get; set; }
        public string SiteAdminEmail2 { get; set; }
        public string SiteAdminEmail3 { get; set; }
        public DateTime SiteLastUpdate { get; set; }
    }
}
