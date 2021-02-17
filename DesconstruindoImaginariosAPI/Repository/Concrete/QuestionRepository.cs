using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Concrete
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        private readonly DataContext _context;
        public QuestionRepository(DataContext context) : base(context)
        {
            this._context = context;
        }

        public Question GetQuestion(int id)
        {
            return this._context.Questions.FindAsync(id).Result;
        }

        public async Task<IEnumerable<Question>> GelAllQuestions()
        {
            return await _context.Questions.ToListAsync();
        }

        public bool QuestionExists(int id)
        {
            return _context.Questions.Any(x => x.Id == id);
        }

    }
}
