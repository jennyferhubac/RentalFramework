using RentalFramework.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalFramework.services
{
    public interface IUserService
    {
        AUser Login(AUser user);
        bool AddUser(AUser user);
        bool Logout(AUser user);
    }
}
