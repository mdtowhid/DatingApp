using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reddocoin.Models;

namespace Reddocoin.Data
{
    public class ChartService
    {
        private readonly ReddocoinDbContext _context;
        public ChartService(ReddocoinDbContext context)
        {
            _context = context;
        }
        public async Task<Chart[]> GetChartDataAsync()
        {
            return await _context.Charts.ToArrayAsync();
        }

        public async Task<double[]> GetChartSeriesDataAsync()
        {
            var charts = await GetChartDataAsync();
            var data = new double[] { };

            foreach (Chart chart in charts)
            {
                data = data.Concat(new double[]{ (double)chart.Value }).ToArray();
            }

            return data;
        }
    }
}
