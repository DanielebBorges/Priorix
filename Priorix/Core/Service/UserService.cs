using Priorix.Priorix.Core.Entities;
using Priorix.Priorix.Core.Interfaces.IRepositories;
using Priorix.Priorix.Core.Interfaces.IServices;

namespace Priorix.Priorix.Core.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetUsers();
        }

        public User GetUserById(int id)
        {
            try
            {
                return _userRepository.FindById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public bool UserExists(int id)
        {
            return _userRepository.UserExists(id);
        }
    }
}
