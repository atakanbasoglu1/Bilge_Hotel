using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

        //veritabanında bulunan entitylere ait daha spesifik sorgular barındıran metotları oluştur.
        Task<List<T>> GetByConditionAsync(Expression<Func<T, bool>> predicate);



    }
}
