using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;

namespace DesconstruindoImaginariosAPI.Repository.Concrete
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        private readonly DataContext _context;

        public QuestionRepository(DataContext context) : base (context) { }

    }
}
