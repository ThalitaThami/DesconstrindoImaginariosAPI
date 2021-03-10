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
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService answerService;

        public AnswerController(IAnswerService answerService)
        {
            this.answerService = answerService;
        }


        // POST: api/Answer
        [HttpPost]
        public async Task<ActionResult<Answer>> PostAnswerAsync(Answer answer)
        {
            await this.answerService.AddAnswerAsync(answer);

            return CreatedAtAction("GetAnswer", new { id = answer.Id }, answer);
        }

        // GET: api/Answer/5
        [HttpGet("{id}")]
        public ActionResult<Answer> GetAnswer(int id)
        {
            Answer answer = this.answerService.GetAnswerById(id);

            if (answer == null)
            {
                return NotFound();
            }

            return answer;
        }

        // GET: api/Answer
        [HttpGet]
        public async Task<IEnumerable<Answer>> GetAnswers()
        {
            return await this.answerService.GetAllAnswersAsync();
        }


        // PUT: api/Answer/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnswer(int id, Answer answer)
        {
            if (id != answer.Id)
            {
                return BadRequest();
            }

            if (!this.answerService.AnswerExists(id))
            {
                return NotFound();
            }

            await this.answerService.UpdateAnswerAsync(answer);

            return Ok();
        }


        // DELETE: api/Answer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Answer>> DeleteAnswer(int id)
        {
            if (!this.answerService.AnswerExists(id))
            {
                return NotFound();
            }

            Answer answer = this.answerService.GetAnswerById(id);
            await this.answerService.DeleteAnswerAsync(answer);

            return answer;
        }
    }
}
