using Microsoft.AspNetCore.Mvc;
using TheRuns.Models;
using TheRuns.Services;

namespace TheRuns.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("id")]
        public UserDetails GetUser(string id)
        {
            return _userService.GetUser(id);
        }

        [HttpPost]
        public string CreateUser(CreateUserRequest user)
        {
            return _userService.CreateUser(user);
        }

        [HttpPut]
        public void UpdateUser(UserDetails user)
        {
            _userService.UpdateUser(user);
        }

        [HttpDelete]
        public void DeleteUser(string id)
        {
            _userService.DeleteUser(id);
        }
    }
}
