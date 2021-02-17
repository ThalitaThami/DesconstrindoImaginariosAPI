using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Concrete
{
    public class ModuleRepository : RepositoryBase<Module>, IModuleRepository
    {
        private readonly DataContext _context;
        public ModuleRepository(DataContext context) : base(context) 
        {
            this._context = context;
        }

        public Module GetModule(int id)
        {
            return this._context.Modules.FindAsync(id).Result;
        }

        public async Task<IEnumerable<Module>> GelAllModules()
        {
            return await _context.Modules.ToListAsync();
        }

        public bool ModuleExists(int id)
        {
            return _context.Modules.Any(x => x.Id == id);
        }
    }
}
