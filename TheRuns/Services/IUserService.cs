using TheRuns.Models;

namespace TheRuns.Services
{
    public interface IUserService
    {
        User GetUser(Guid id);
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(Guid id);
    }
}
