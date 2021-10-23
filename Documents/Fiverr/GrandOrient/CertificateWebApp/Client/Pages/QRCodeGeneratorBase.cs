using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CertificateWebApp.Client.Services;
using CertificateWebApp.Shared.Models;
using Microsoft.AspNetCore.Components;
using QRCoder;
using static QRCoder.QRCodeGenerator.ECCLevel;

namespace CertificateWebApp.Client.Pages
{
    public class QRCodeGeneratorBase:ComponentBase
    {
        [Inject] 
        public QrCodeGeneratorService QrCodeGeneratorService { get; set; }
        public QRCodeInfoGenerator QrCodeInfoGenerator { get; set; } = new QRCodeInfoGenerator();
        public string ImageBase64Text { get; set; } = "data:image/png;base64,";
        public bool IsSavedQrCode { get; set; }


        public List<QRCodeInfoGenerator> QrCodeInfoGenerators { get; set; }

        protected override async Task OnInitializedAsync()
        {
            QrCodeInfoGenerator.BirthDate = DateTime.Today;
            StateHasChanged();
        }

        public async Task HandleValidSubmit()
        {
            var qrCodeInfo = await QrCodeGeneratorService.PostQrCodeInfoAsync(QrCodeInfoGenerator);
            if (qrCodeInfo?.Id != null)
            {
                IsSavedQrCode = true;
                ImageBase64Text += qrCodeInfo.QRCode;
            }

            StateHasChanged();
        }
    }
}
