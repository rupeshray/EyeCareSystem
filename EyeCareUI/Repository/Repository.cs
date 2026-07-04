using EyeCareUI.DataBase;
using Microsoft.EntityFrameworkCore;

namespace EyeCareUI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
       => await _dbSet.ToListAsync();

        public async Task<T?> GetByIdAsync(object id)
            => await _dbSet.FindAsync(id);

        public async Task AddAsync(T entity)
            => await _dbSet.AddAsync(entity);

        public Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task SaveAsync()
            => await _context.SaveChangesAsync();
    }
}
