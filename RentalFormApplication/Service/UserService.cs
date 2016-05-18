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
    public class UserService : IUserService
    {
        IUserDAO userDal;

        public UserService()
        {
            userDal = new UserDAO();
        }
        public bool AddUser(AUser user)
        {
            return userDal.AddUser(user);
        }

        public AUser Login(AUser user)
        {
            return userDal.Login(user);
        }

        public bool Logout(AUser user)
        {
            throw new NotImplementedException();
        }
    }
}
