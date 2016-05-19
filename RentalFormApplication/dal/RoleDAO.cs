using RentalFramework.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;
using RentalFormApplication.database;

namespace RentalFormApplication.dal
{
    public class RoleDAO : IRoleDAO
    {
        public bool AddRole(ARole role)
        {
            DBTables.ROLE_TABLE.Add(role);
            return true;
        }
    }
}
