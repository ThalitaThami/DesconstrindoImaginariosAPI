using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Concrete
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        private readonly DataContext _context;
        public AnswerRepository(DataContext context) : base(context)
        {
            this._context = context;
        }

        public Answer GetAnswer(int id)
        {
            return this._context.Answers.FindAsync(id).Result;
        }

        public async Task<IEnumerable<Answer>> GelAllAnswers()
        {
            return await _context.Answers.ToListAsync();
        }

        public bool AnswerExists(int id)
        {
            return _context.Answers.Any(x => x.Id == id);
        }
    }
}
