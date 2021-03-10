using DesconstruindoImaginariosAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository.Abstract
{
    public interface IAnswerRepository : IRepositoryBase<Answer>
    {
        public Answer GetAnswer(int id);
        public Task<IEnumerable<Answer>> GelAllAnswers();
        public bool AnswerExists(int id);
    }
}
