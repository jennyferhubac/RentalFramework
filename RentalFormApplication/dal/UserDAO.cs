using RentalFramework.dal;
using System;
using RentalFramework.entities;
using RentalFormApplication.entities;
using RentalFormApplication.database;
using System.Collections.Generic;
using System.Linq;

namespace RentalFormApplication.dal
{
    public class UserDAO : IUserDAO
    {
        public bool AddUser(AUser user)
        {
            DBTables.USER_TABLE.Add(user);
            return true;
        }

        public AUser Login(AUser user)
        {
            List<User> users = DBTables.USER_TABLE.Select(u => u as User).ToList();

            User userInfo = user as User;
            var result = users.Where(u => u.UserName == userInfo.UserName && u.Password==userInfo.Password).FirstOrDefault();

            return result;

            //if (result != null)
            //    return result;
            //else
            //    return new User();
        }

        public bool Logout(AUser user)
        {
            throw new NotImplementedException();
        }
    }
}
