using DesconstruindoImaginariosAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Abstract
{
    public interface IModuleRepository : IRepositoryBase<Module>
    {
        public Module GetModule(int id);
        public Task<IEnumerable<Module>> GelAllModules();
        public bool ModuleExists(int id);
    }
}
