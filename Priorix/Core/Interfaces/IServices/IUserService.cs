using Priorix.Priorix.Core.Entities;

namespace Priorix.Priorix.Core.Interfaces.IServices
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        public User GetUserByEmail(string email);
        public void CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int id);
        public bool UserExists(int id);
    }
}

