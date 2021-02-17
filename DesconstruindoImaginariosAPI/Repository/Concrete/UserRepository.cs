using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Concrete
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context) : base(context) 
        {
            this._context = context;
        }

        public User GetUser(int id)
        {
            return this._context.Users.FindAsync(id).Result;
        }

        public async Task<IEnumerable<User>> GelAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public bool UserExists(int id)
        {
            return _context.Users.Any(x => x.Id == id);
        }
    }
}
