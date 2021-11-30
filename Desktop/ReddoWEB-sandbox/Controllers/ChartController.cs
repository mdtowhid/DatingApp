using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddocoin.Data;

namespace Reddocoin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly ChartService _service;

        public ChartController(ChartService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetChartSeriesDataAsync());
        }
    }
}
