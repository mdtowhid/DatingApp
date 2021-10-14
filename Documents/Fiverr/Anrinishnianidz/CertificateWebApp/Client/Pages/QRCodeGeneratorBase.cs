using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CertificateWebApp.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace CertificateWebApp.Client.Pages
{
    public class QRCodeGeneratorBase:ComponentBase
    {
        public QRCodeInfoGenerator QrCodeInfoGenerator { get; set; } = new QRCodeInfoGenerator();
        public List<QRCodeInfoGenerator> QrCodeInfoGenerators { get; set; }


        public async Task HandleValidSubmit()
        {
        }
    }
}
