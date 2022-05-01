using Cleansiness.Shared.Enums;
using Cleansiness.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleansiness.Shared.DTO
{
    public class AuditMasterCreationDto : AuditMaster
    {
        [NotMapped]
        public List<Area> Areas { get; set; }
        [NotMapped]
        public List<Site> Sites { get; set; }
        [NotMapped]
        public List<Supervisor> Supervisors { get; set; }

        public AuditMasterCreationDto()
        {
            Supervisors = new List<Supervisor>()
            {
                new Supervisor(){Id=1, Name="Karen Banks"},
                new Supervisor(){Id=2, Name="Pauline Curdie"},
                new Supervisor(){Id=3, Name="Julie Fessey"},
                new Supervisor(){Id=4, Name="Oyleaca Fletcher"},
                new Supervisor(){Id=5, Name="Gail Francis"},
            };
        }
    }
}
