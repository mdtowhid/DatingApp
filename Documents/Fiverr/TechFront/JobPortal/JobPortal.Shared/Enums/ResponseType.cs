using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Shared.Enums
{
    public enum ResponseType
    {
        Add = 1,
        Remove = 2,
        Update = 3,
        All = 4,
        Search = 5,
        Failed = 6,
        CountZero = 7,
        WithPagedList = 8,
        AlreadyExist = 9,
        NotFound = 10,
        ListAddOrUpdate = 11,
        SendingEmail = 12,
    }
}
