using TheRuns.Models;

namespace TheRuns.Services
{
    public interface IUserService
    {
        UserDetails GetUser(string id);
        string CreateUser(CreateUserRequest user);
        void UpdateUser(UpdateUserRequest user);
        void DeleteUser(string id);
    }
}
