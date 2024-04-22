using SUT23_UserAPI.Models;

namespace SUT23_UserAPI.Services
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUser(int id);
        User AddUser(User newUser);
        void DeleteUser(User user);
        User Update(User user);
    }
}
