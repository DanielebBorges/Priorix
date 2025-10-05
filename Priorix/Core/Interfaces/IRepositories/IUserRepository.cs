using Priorix.Priorix.Core.Entities;

namespace Priorix.Priorix.Core.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUserByEmail(string email);
        public User FindById(int id);
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int id);
        public bool UserExists(int id);
    }
}
