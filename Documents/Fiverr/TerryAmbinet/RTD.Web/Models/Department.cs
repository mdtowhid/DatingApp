using System;
using System.ComponentModel.DataAnnotations;

namespace RTD.Web.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateTime DeptLastUpdate { get; set; }
    }
}
