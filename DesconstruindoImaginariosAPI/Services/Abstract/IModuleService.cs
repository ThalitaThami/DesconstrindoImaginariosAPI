using DesconstruindoImaginariosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Abstract
{
    public interface IModuleService
    {
        public Task<IEnumerable<Module>> GetAllModulesAsync();
        public Module GetModuleById(int id);
        public Task UpdateModuleAsync(Module module);
        public Task AddModuleAsync(Module module);
        public Task DeleteModuleAsync(Module module);
        public bool ModuleExists(int id);
    }
}
