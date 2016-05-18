using RentalFramework.dal;
using System;
using RentalFramework.entities;
using RentalFormApplication.entities;

namespace RentalFormApplication.dal
{
    public class UserDAO : IUserDAO
    {
        public bool AddUser(AUser user)
        {
            throw new NotImplementedException();
        }

        public AUser Login(AUser user)
        {
            if (user.UserId == 1)
                return user;
            else
               return new User();
        }

        public bool Logout(AUser user)
        {
            throw new NotImplementedException();
        }
    }
}
