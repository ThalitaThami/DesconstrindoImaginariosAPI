using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Services.Abstract;

namespace DesconstruindoImaginariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }


        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> PostUserAsync(User user)
        {
            await this.userService.AddUserAsync(user);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            User user = this.userService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await this.userService.GetAllUsersAsync();
        }


        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if (!this.userService.UserExists(id))
            {
                return NotFound();
            }

            await this.userService.UpdateUserAsync(user);

            return Ok();
        }


        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            if (!this.userService.UserExists(id))
            {
                return NotFound();
            }

            User user = this.userService.GetUserById(id);
            await this.userService.DeleteUserAsync(user);

            return user;
        }
    }
}
