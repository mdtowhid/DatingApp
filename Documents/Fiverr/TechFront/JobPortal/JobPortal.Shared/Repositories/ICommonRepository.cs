using JobPortal.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.Repositories
{
    public interface ICommonRepository
    {
        Task<List<Region>> GetRegionList();
        Task<List<City>> GetCityList();
        Task<List<UserType>> GetUserTypeList();
    }
}
