using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.dal
{
    public interface IRoleDAO
    {
        bool AddRole(ARole role);
    }
}
