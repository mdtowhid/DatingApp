using JobPortal.Models;
using JobPortal.Shared.Models;
using JobPortal.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Services
{
    public class CommonService : ICommonRepository
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public CommonService(IWebHostEnvironment env, AppDbContext context, IConfiguration config)
        {
            _env = env;
            _context = context;
            _config = config;
        }
        public async Task<List<City>> GetCityList()
        {
            var vCityList = await _context.Cities.ToListAsync();
            return vCityList;
        }

        public async Task<List<Region>> GetRegionList()
        {
            var vRegionList = await _context.Regions.ToListAsync();
            return vRegionList;
        }

        public async Task<List<UserType>> GetUserTypeList()
        {
            var vUserTypeList = await _context.UserTypes.ToListAsync();
            return vUserTypeList;
        }
    }
}
