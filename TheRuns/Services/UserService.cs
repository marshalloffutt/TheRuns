using MongoDB.Driver;
using TheRuns.Models;
using TheRuns.Models.DB;
using TheRuns.Services.Utils;

namespace TheRuns.Services
{
    public class UserService : IUserService
    {

        private readonly IMongoCollection<UserDto> users;

        public UserService(IUserDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            users = database.GetCollection<UserDto>(settings.UsersCollectionName);
        }

        public UserDetails GetUser(string id)
        {
            var userDb = users.Find(user => user.Id == id).SingleOrDefault();
            var userDetails = UserServiceUtils.MapToUserDetails(userDb);
            return userDetails;
        }

        public string CreateUser(CreateUserRequest user)
        {
            var newUser = UserServiceUtils.MapToUserDto(user);
            users.InsertOne(newUser);
            var id = newUser.Id;
            return id;
        }

        public void UpdateUser(UpdateUserRequest userRequest)
        {
            var userToUpdate = users.Find(user => user.Id == userRequest.StringId).SingleOrDefault();
            var userToReplace = UserServiceUtils.UpdateUserDto(userRequest, userToUpdate);
            users.ReplaceOne(u => u.Id == userToUpdate.Id, userToReplace);
        }

        public void DeleteUser(string id)
        {
            var userToDelete = users.Find(u => u.Id == id).First();
            if (userToDelete != null)
            {
                users.DeleteOne(u => u.Id == userToDelete.Id);
            }
        }
    }
}
