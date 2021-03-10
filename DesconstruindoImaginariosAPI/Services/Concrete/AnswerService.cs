using DesconstruindoImaginariosAPI.Models;
using DesconstruindoImaginariosAPI.Repository.Abstract;
using DesconstruindoImaginariosAPI.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Services.Concrete
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository answerRepository;

        public AnswerService(IAnswerRepository answerRepository)
        {
            this.answerRepository = answerRepository;
        }

        public async Task AddAnswerAsync(Answer answer)
        {
            await this.answerRepository.AddAsync(answer);
        }        

        public async Task DeleteAnswerAsync(Answer answer)
        {
            await this.answerRepository.DeleteAsync(answer);
        }

        public async Task<IEnumerable<Answer>> GetAllAnswersAsync()
        {
            return await this.answerRepository.GelAllAnswers();
        }

        public Answer GetAnswerById(int id)
        {
            return this.answerRepository.GetAnswer(id);
        }

        public async Task UpdateAnswerAsync(Answer answer)
        {
            try
            {
                await this.answerRepository.UpdateAsync(answer);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public bool AnswerExists(int id)
        {
            return this.answerRepository.AnswerExists(id);
        }
    }
}
