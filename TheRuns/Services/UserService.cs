using TheRuns.Models;

namespace TheRuns.Services
{
    public class UserService : IUserService
    {

        public UserService()
        {
            //connect to db
        }

        public UserDetails GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public string CreateUser(CreateUserRequest user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDetails user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}
