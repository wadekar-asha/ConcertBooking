using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Repositories.Generic
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private ApplicationDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

            //_context.departments
            //_context.employees.tolist()


            //EntityState :  Attach, modified,Deatached
        }

        public async Task DeleteEntity(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);

            }
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveEntity(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEntity(T entity)
        {
            _context.Update(entity);
            _context.Entry(entity).State = EntityState.Modified;              
            await _context.SaveChangesAsync();
        }
    }
}
