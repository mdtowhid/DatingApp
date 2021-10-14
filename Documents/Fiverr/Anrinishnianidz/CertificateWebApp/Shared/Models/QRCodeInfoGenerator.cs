using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateWebApp.Shared.Models
{
    public class QRCodeInfoGenerator
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Zip code is required.")]
        [StringLength(4, ErrorMessage = "Zip code must be 4 characters long.")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Street is required.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Birth date is required.")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Mobile No is required.")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Insurance company is required.")]
        public string InsuranceCompany { get; set; }
        [Required(ErrorMessage = "Insurance Company Card Nr is required.")]
        public string InsuranceCompanyCardNr { get; set; }
        public string QRCode { get; set; }
    }
}
