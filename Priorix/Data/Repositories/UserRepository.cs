using Priorix.Priorix.Core.Entities;
using Priorix.Priorix.Data.Context;
using Priorix.Priorix.Core.Interfaces.IRepositories;

namespace Priorix.Priorix.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _db;

        public UserRepository(DataContext db)
        {
            _db = db;
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
