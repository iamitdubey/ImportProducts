using System;
using System.Threading.Tasks;

namespace ImportProducts.DataAccess
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        Task Create(T entity);
        Task Delete(T entity);
        Task Update(T entity);
    }
}
