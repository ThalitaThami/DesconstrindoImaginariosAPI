using DesconstruindoImaginariosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Abstract
{
    public interface IUserRepository: IRepositoryBase<User>
    {
        public User GetUser(int id);
        public Task<IEnumerable<User>> GelAllUsers();

        public bool UserExists(int id);
    }
}
