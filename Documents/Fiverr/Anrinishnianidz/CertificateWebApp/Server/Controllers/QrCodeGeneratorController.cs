using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CertificateWebApp.Server.Entities;
using CertificateWebApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

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


        [HttpPost("AddQrCodeInfo")]
        public async Task<IActionResult> AddQrCodeInfo(QRCodeInfoGenerator model)
        {
            bool drugExists = await _dbContext.QRCodeInfoGenerators.AnyAsync(x => x.Id == model.Id);
            if (drugExists)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }
            await _dbContext.QRCodeInfoGenerators.AddAsync(model);
            await _dbContext.SaveChangesAsync();

            Response.StatusCode = StatusCodes.Status201Created;
            return Ok(model.Id);
        }
    }
}
