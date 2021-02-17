using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using DesconstruindoImaginariosAPI.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Concrete
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public async Task AddQuestionAsync(Question question)
        {
            await this.questionRepository.AddAsync(question);
        }

        public async Task DeleteQuestionAsync(Question question)
        {
            await this.questionRepository.DeleteAsync(question);
        }

        public Question GetQuestionById(int id)
        {
            return this.questionRepository.GetQuestion(id);
        }

        public async Task<IEnumerable<Question>> GetAllQuestionsAsync()
        {
            return await this.questionRepository.GelAllQuestions();
        }

        public async Task UpdateQuestionAsync(Question question)
        {
            try
            {
                await this.questionRepository.UpdateAsync(question);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public bool QuestionExists(int id)
        {
            return this.questionRepository.QuestionExists(id);
        }
    }
}
