using DesconstruindoImaginariosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Abstract
{
    public interface IQuestionRepository : IRepositoryBase<Question>
    {
        public Question GetQuestion(int id);
        public Task<IEnumerable<Question>> GelAllQuestions();
        public bool QuestionExists(int id);
    }
}
