using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Services.Abstract;

namespace DesconstruindoImaginariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService questionService;

        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        // GET: api/Questions
        [HttpGet]
        public async Task<IEnumerable<Question>> GetQuestions()
        {
            return await this.questionService.GetAllQuestionsAsync();
        }

        // GET: api/Questions/5
        [HttpGet("{id}")]
        public ActionResult<Question> GetQuestion(int id)
        {
            var question = this.questionService.GetQuestionById(id);

            if (question == null)
            {
                return NotFound();
            }

            return question;
        }

        // PUT: api/Questions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestion(int id, Question question)
        {
            if (id != question.Id)
            {
                return BadRequest();
            }

            if (!this.questionService.QuestionExists(id))
            {
                return NotFound();
            }

            await this.questionService.UpdateQuestionAsync(question);

            return NoContent();
        }

        // POST: api/Questions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Question>> PostQuestion(Question question)
        {
            await this.questionService.AddQuestionAsync(question);            

            return CreatedAtAction("GetQuestion", new { id = question.Id }, question);
        }

        // DELETE: api/Questions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Question>> DeleteQuestion(int id)
        {
            var question = this.questionService.GetQuestionById(id);
            if (question == null)
            {
                return NotFound();
            }

            await this.DeleteQuestion(id);

            return question;
        }
    }
}
