using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Entities.Abstract;
using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly BilgeHotelContext _context;
        public BaseRepository(BilgeHotelContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {

            await _context.Set<T>().AddAsync(entity);

            _context.SaveChanges();

        }

        public async Task DeleteAsync(int id)
        {
            //    var entity = await _context.Set<T>().FindAsync(id);
            //    _context.Remove(entity);
            var deletedEntity = await GetByIdAsync(id);
            var entity = _context.Set<T>();
            entity.Remove(deletedEntity);

            _context.SaveChanges();

        }

        public async Task<List<T>> GetAllAsync()
        {
            //todo: Adı Async olan bu metot neden awaitbeklemiyor???
            return await _context.Set<T>().ToListAsync();

        }



        public Task<List<T>> GetByConditionAsync(Expression<Func<T, bool>> predicate)
        {
            //aşağıdaki GetByConditionAsync isimli metodun gövdesini doldur.
            return _context.Set<T>().Where(predicate).ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            var tEntity = await _context.Set<T>().FindAsync(id);
            return tEntity;
        }

        public async Task UpdateAsync(T entity)
        {

            //_context.Set<T>().Update(entity);
            _context.Set<T>().Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
