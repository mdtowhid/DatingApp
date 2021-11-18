using RTD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTD.Web.Repositories
{
    public interface IUtilityRepository
    {
        List<Department> GetDepartments();
    }
}
