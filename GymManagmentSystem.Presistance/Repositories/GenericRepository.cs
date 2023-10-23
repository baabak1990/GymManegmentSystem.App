using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagmentSystem.Presistance.Context;
using GymManegmentApplication.Contracts.Presistance;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Presistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Constructor

        private readonly GymManagementDbContext _context;
        public GenericRepository(GymManagementDbContext context)
        {
            _context = context;
        }

        #endregion


        public  async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<T> Add(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> IsExisted(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }
    }
}
