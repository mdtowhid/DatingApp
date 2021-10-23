using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using CertificateWebApp.Server.Entities;
using CertificateWebApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using QRCoder;

namespace CertificateWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrCodeGeneratorController : ControllerBase
    {
        private readonly CertificateWebAppDbContext _dbContext;

        public QrCodeGeneratorController(CertificateWebAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetQrCodeInfosAsync")]
        public async Task<ActionResult<List<QRCodeInfoGenerator>>> GetQrCodeInfosAsync()
        {
            return await _dbContext.QRCodeInfoGenerators.ToListAsync();
        }

        [HttpGet("GetQrCodeInfoAsync/{id}")]
        public async Task<ActionResult<QRCodeInfoGenerator>> GetQrCodeInfoAsync(Guid id)
        {
            return await _dbContext.QRCodeInfoGenerators.FirstOrDefaultAsync(x=>x.Id == id);
        }

        [HttpPut("UpdateQrCodeInfo")]
        public async Task<IActionResult> UpdateQrCodeInfo(QRCodeInfoGenerator model)
        {
            bool qrcodeInfoExist = await _dbContext.QRCodeInfoGenerators.AnyAsync(x => x.Id == model.Id);
            if (!qrcodeInfoExist)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }

            var entityEntryQrCodeInfoGen = _dbContext.QRCodeInfoGenerators.Update(model);
            var e = await _dbContext.SaveChangesAsync();

            Response.StatusCode = StatusCodes.Status201Created;
            return Ok(entityEntryQrCodeInfoGen.Entity);
        }


        [HttpPost("AddQrCodeInfo")]
        public async Task<IActionResult> AddQrCodeInfo(QRCodeInfoGenerator model)
        {
            model.Id = Guid.NewGuid();
            model.QRCode = await GenerateQrCodeAsync(model);
            var entityEntryQrCodeInfoGen = await _dbContext.QRCodeInfoGenerators.AddAsync(model);
            await _dbContext.SaveChangesAsync();

            Response.StatusCode = StatusCodes.Status201Created;
            return Ok(entityEntryQrCodeInfoGen.Entity);
        }

        [HttpPost("GenerateQrCode")]
        public async Task<string> GenerateQrCodeAsync(QRCodeInfoGenerator model)
        {
            if (!ModelState.IsValid)
                return "";

            string strQrCode = string.Empty;
            Dictionary<string, string> genericDictionary = new();
            genericDictionary.Add("Id", model.Id.ToString());
            genericDictionary.Add("FirstName", model.FirstName);
            genericDictionary.Add("LastName", model.LastName);
            genericDictionary.Add("ZipCode", model.ZipCode);
            genericDictionary.Add("Street", model.Street);
            genericDictionary.Add("BirthDate", model.BirthDate.ToString(CultureInfo.InvariantCulture));
            genericDictionary.Add("MobileNo", model.MobileNo);
            genericDictionary.Add("InsuranceCompany", model.InsuranceCompany);
            genericDictionary.Add("InsuranceCompanyCardNr", model.InsuranceCompanyCardNr);

            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(string.Join("\n", genericDictionary.Values),
                    QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                using (Bitmap bitMap = qrCode.GetGraphic(20))
                {
                    bitMap.Save(ms, ImageFormat.Png);
                    strQrCode = Convert.ToBase64String(ms.ToArray());
                }
            }

            return strQrCode;
        }
    }
}
