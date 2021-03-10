using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Services.Abstract;

namespace DesconstruindoImaginariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly IModuleService moduleService;

        public ModuleController(IModuleService moduleService)
        {
            this.moduleService = moduleService;
        }

        // GET: api/Modules
        [HttpGet]
        public async Task<IEnumerable<Module>> GetModules()
        {
            return await this.moduleService.GetAllModulesAsync();
        }

        // GET: api/Modules/5
        [HttpGet("{id}")]
        public  ActionResult<Module> GetModule(int id)
        {
            var module = this.moduleService.GetModuleById(id);

            if (module == null)
            {
                return NotFound();
            }

            return module;
        }

        // PUT: api/Modules/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModule(int id, Module module)
        {
            if (id != module.Id)
            {
                return BadRequest();
            }

            if (!this.moduleService.ModuleExists(id))
            {
                return NotFound();
            }

            await this.moduleService.UpdateModuleAsync(module);           

            return Ok();
        }

        // POST: api/Modules
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Module>> PostModule(Module module)
        {
            await this.moduleService.AddModuleAsync(module);

            return CreatedAtAction("GetModule", new { id = module.Id }, module);
        }

        // DELETE: api/Modules/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Module>> DeleteModule(int id)
        {
            Module module = this.moduleService.GetModuleById(id);

            if (module == null)
            {
                return NotFound();
            }

            await this.moduleService.DeleteModuleAsync(module);
            
            return module;
        }
    }
}
