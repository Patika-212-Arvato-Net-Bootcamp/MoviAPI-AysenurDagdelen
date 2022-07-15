using Microsoft.EntityFrameworkCore;
using Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;
        
        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _appDbContext.Set<T>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _appDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _appDbContext.Set<T>().FirstOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _appDbContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _appDbContext.Set<T>().Update(entity);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
