using DesconstruindoImaginariosAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Abstract
{
    public interface IAnswerService
    {
        public Task<IEnumerable<Answer>> GetAllAnswersAsync();
        public Answer GetAnswerById(int id);
        public Task UpdateAnswerAsync(Answer user);
        public Task AddAnswerAsync(Answer user);
        public Task DeleteAnswerAsync(Answer user);
        public bool AnswerExists(int id);
    }
}
