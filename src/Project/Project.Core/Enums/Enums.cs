using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Enums
{
    public enum Status
    {
        Active,
        Inactive,
        Closed,
        Completed,
        Waiting
    }

    public enum UserType
    {
        Administrator,
        SuperAdministrator,
        User,
        Reporter
    }
}
