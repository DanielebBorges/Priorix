using Priorix.Priorix.Core.Entities;
using Priorix.Priorix.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Priorix.Priorix.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        public IActionResult GetUsers()
        {
            List<User> users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpPost(Name = "CreateUser")]
        public IActionResult PostUser([FromBody] User user)
        {
            _userService.CreateUser(user);
            return Ok();
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public IActionResult GetUserById(int id)
        {
            User user = _userService.GetUserById(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpGet("email/{email}", Name = "GetUserByEmail")]
        public IActionResult GetUserByEmail(string email)
        {
            User user = _userService.GetUserByEmail(email);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPut(Name = "UpdateUser")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("{id}", Name = "DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

        [HttpGet("exists/{id}", Name = "UserExists")]
        public IActionResult UserExists(int id)
        {
            bool exists = _userService.UserExists(id);
            return Ok(exists);
        }
    }
}
