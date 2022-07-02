using TheRuns.Models;
using TheRuns.Models.DB;
using System.Security.Cryptography;

namespace TheRuns.Services.Utils
{
    public class UserServiceUtils
    {
        public static UserDetails MapToUserDetails(UserDto userDb)
        {
            var userDetails = new UserDetails()
            {
                Id = userDb.Id,
                FirstName = userDb.FirstName,
                LastName = userDb.LastName,
                DateOfBirth = userDb.DateOfBirth,
                Email = userDb.Email,
            };

            return userDetails;
        }

        public static UserDto MapToUserDto(CreateUserRequest user)
        {
            byte[] passwordSalt;
            byte[] passwordHash;

            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(user.Password));
            }

            var newUser = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            return newUser;
        }

        public static UserDto UpdateUserDto(UpdateUserRequest userRequest, UserDto userDb)
        {
            var user = new UserDto()
            {
                Id = userDb.Id,
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                DateOfBirth = userRequest.DateOfBirth,
                Email = userRequest.Email,
                PasswordHash = userDb.PasswordHash,
                PasswordSalt = userDb.PasswordSalt
            };

            return user;
        }
    }
}
