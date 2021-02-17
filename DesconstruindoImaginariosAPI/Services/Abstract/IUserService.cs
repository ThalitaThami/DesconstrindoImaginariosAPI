using DesconstruindoImaginariosAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Abstract
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAllUsersAsync();
        public User GetUserById(int id);
        public Task UpdateUserAsync(User user);
        public Task AddUserAsync(User user);
        public Task DeleteUserAsync(User user);
        public bool UserExists(int id);
    }
}
