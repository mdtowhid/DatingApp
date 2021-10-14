using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using CertificateWebApp.Shared.Models;

namespace CertificateWebApp.Client.Services
{
    public class QrCodeGeneratorService
    {
        private static HttpClient _httpClient;
        private static readonly string BaseAddress = "api/QrCodeGenerator/";

        public QrCodeGeneratorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public QrCodeGeneratorService()
        {

        }

        public static async Task<QRCodeInfoGenerator> PutQrCoInfoAsync(QRCodeInfoGenerator newQRCodeInfoGenerator)
        {
            var httpResponseMessage = await _httpClient.PutAsJsonAsync($"drug/{newQRCodeInfoGenerator.Id}", newQRCodeInfoGenerator);
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                var errorMessage = httpResponseMessage.ReasonPhrase;
                Console.WriteLine($"There was an error! {errorMessage}");
                return null;
            }
            return newQRCodeInfoGenerator;
        }

        public static async Task<QRCodeInfoGenerator> PostQrCoInfoAsync(QRCodeInfoGenerator newQRCodeInfoGenerator)
        {
            var httpResponseMessage = await _httpClient.PostAsJsonAsync($"{BaseAddress}AddQrCodeInfo", newQRCodeInfoGenerator);
            var stream = await httpResponseMessage.Content.ReadAsStreamAsync();
            var drugId = await JsonSerializer.DeserializeAsync<Guid>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            newQRCodeInfoGenerator.Id = drugId;
            return newQRCodeInfoGenerator;
        }

        public static async Task<List<QRCodeInfoGenerator>> GetQrCoInfosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<QRCodeInfoGenerator>>("drug/GetAllDrugs");
        }
    }
}
