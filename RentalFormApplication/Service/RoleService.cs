using RentalFramework.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;
using RentalFramework.dal;
using RentalFormApplication.dal;

namespace RentalFormApplication.Service
{
    public class RoleService : IRoleService
    {
        IRoleDAO roleDal;
        private static RoleService instance;
        public RoleService()
        {
            roleDal = new RoleDAO();
        }

        public static RoleService getInstance()
        {
            if (instance == null)
                instance = new RoleService();
            return instance;
        }
        public bool AddRole(ARole role)
        {
            return roleDal.AddRole(role);
        }
    }
}
