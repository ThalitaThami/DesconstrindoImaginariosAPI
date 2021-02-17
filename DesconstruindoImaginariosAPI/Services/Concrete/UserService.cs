using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using DesconstruindoImaginariosAPI.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task AddUserAsync(User user)
        {
            await this.userRepository.AddAsync(user);  
        }

        public async Task DeleteUserAsync(User user)
        {
            await this.userRepository.DeleteAsync(user);
        }

        public User GetUserById(int id)
        {
            return this.userRepository.GetUser(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await this.userRepository.GelAllUsers();
        }
              
        public async Task UpdateUserAsync(User user)
        {         
            try
            {
                await this.userRepository.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public bool UserExists(int id)
        {
            return this.userRepository.UserExists(id);
        }
    }
}
