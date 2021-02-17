using DesconstruindoImaginariosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Abstract
{
    public interface IQuestionService
    {
        public Task<IEnumerable<Question>> GetAllQuestionsAsync();
        public Question GetQuestionById(int id);
        public Task UpdateQuestionAsync(Question question);
        public Task AddQuestionAsync(Question question);
        public Task DeleteQuestionAsync(Question question);
        public bool QuestionExists(int id);
    }
}
