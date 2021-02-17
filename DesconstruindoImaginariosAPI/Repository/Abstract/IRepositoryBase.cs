using DesconstruindoImaginariosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Repository
{

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public Task AddAsync<T>(T entity) where T : class;
        public Task UpdateAsync<T>(T entity) where T : class;
        public Task DeleteAsync<T>(T entity) where T : class;

        public Task<int> SaveChangeAsync();
    }
}
