using Microsoft.AspNetCore.Mvc;
using SUT23_UserAPI.Models;

namespace SUT23_UserAPI.Services
{
    public class UserRepo : IUserRepository
    {
        private List<User> users = new List<User>()
        {
            new User() { Id = 101, Name = "Ermin"},
            new User() { Id = 102, Name = "Oskar"},
            new User() { Id = 103, Name = "Sharam"},
            new User() { Id = 104, Name = "Kristian"},
        };
        public User AddUser(User newUser)
        {
            users.Add(newUser);
            return newUser;
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUser(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public User Update(User user)
        {
            var existingUser = GetUser(user.Id);
            existingUser.Name = user.Name;
            return user;
        }

   
    }
}
