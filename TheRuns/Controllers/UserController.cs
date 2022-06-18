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

        [HttpGet]
        public User GetUser(Guid id)
        {
            return _userService.GetUser(id);
        }

        [HttpPost]
        public User CreateUser(User user)
        {
            return _userService.CreateUser(user);
        }

        [HttpPut]
        public User UpdateUser(User user)
        {
            return _userService.UpdateUser(user);
        }

        [HttpDelete]
        public void DeleteUser(Guid userId)
        {
            _userService.DeleteUser(userId);
        }
    }
}
