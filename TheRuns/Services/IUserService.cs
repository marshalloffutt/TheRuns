using TheRuns.Models;

namespace TheRuns.Services
{
    public interface IUserService
    {
        UserDetails GetUser(string id);
        string CreateUser(CreateUserRequest user);
        void UpdateUser(UserDetails user);
        void DeleteUser(string id);
    }
}
