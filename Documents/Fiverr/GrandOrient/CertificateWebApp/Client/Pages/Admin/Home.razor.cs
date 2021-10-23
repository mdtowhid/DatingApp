using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CertificateWebApp.Client.Services;
using CertificateWebApp.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace CertificateWebApp.Client.Pages.Admin
{
    public partial class Home
    {
        [Inject]
        public QrCodeGeneratorService QrCodeGeneratorService { get; set; }

        public QRCodeInfoGenerator QrCodeInfoGenerator { get; set; } = new QRCodeInfoGenerator();
        public List<QRCodeInfoGenerator> QrCodeInfoGenerators { get; set; } = new List<QRCodeInfoGenerator>();
        public string ImageBase64Text { get; set; } = "data:image/png;base64,";
        public bool Updated { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            QrCodeInfoGenerator.Id = Guid.Empty;
            QrCodeInfoGenerators = await QrCodeGeneratorService.GetQrCodeInfosAsync();
            StateHasChanged();
        }

        protected async Task QrCodeClickAsync(Guid id)
        {
            QrCodeInfoGenerator = await QrCodeGeneratorService.GetQrCodeInfoAsync(id);
            QrCodeInfoGenerator.IsUpdatedByWorker = true;
            StateHasChanged();
        }

        public async Task HandleValidSubmit()
        {
            QrCodeInfoGenerator.IsUpdatedByWorker = true;
            var qrCodeInfo = await QrCodeGeneratorService.PutQrCodeInfoAsync(QrCodeInfoGenerator);
            if (qrCodeInfo.IsUpdatedByWorker)
            {
                QrCodeInfoGenerator = new QRCodeInfoGenerator();
                Updated = true;
                QrCodeInfoGenerators = await QrCodeGeneratorService.GetQrCodeInfosAsync();
            }
            StateHasChanged();
        }
    }
}
