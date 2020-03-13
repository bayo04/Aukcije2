using Core;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class Repository<TEntity>
        : IRepository<TEntity>
        where TEntity : class
    {
        protected AppDbContext _appDbContext { get; set; }
        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task Add(TEntity entity)
        {
            await _appDbContext.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _appDbContext.Remove(entity);
        }

        public async Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await _appDbContext.Set<TEntity>().FindAsync(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _appDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _appDbContext.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Update(entity);
        }
    }
}
