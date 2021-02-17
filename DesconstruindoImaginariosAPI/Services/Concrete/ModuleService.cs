using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using DesconstruindoImaginariosAPI.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Concrete
{
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository moduleRepository;

        public ModuleService(IModuleRepository moduleRepository)
        {
            this.moduleRepository = moduleRepository;
        }

        public async Task AddModuleAsync(Module module)
        {
            await this.moduleRepository.AddAsync(module);
        }

        public async Task DeleteModuleAsync(Module module)
        {
            await this.moduleRepository.DeleteAsync(module);
        }

        public Module GetModuleById(int id)
        {
            return this.moduleRepository.GetModule(id);
        }

        public async Task<IEnumerable<Module>> GetAllModulesAsync()
        {
            return await this.moduleRepository.GelAllModules();
        }

        public async Task UpdateModuleAsync(Module module)
        {
            try
            {
                await this.moduleRepository.UpdateAsync(module);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public bool ModuleExists(int id)
        {
            return this.moduleRepository.ModuleExists(id);
        }
    }
}
