using RentalFramework.entities;

namespace RentalFramework.dal
{
    public interface IUserDAO
    {
        AUser Login(AUser user);
        bool AddUser(AUser user);
        bool Logout(AUser user);
    }
}
