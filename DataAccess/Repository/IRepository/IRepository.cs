using System.Linq.Expressions;

namespace Models.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveById(object id);
        void RemoveRange(IEnumerable<T> entity);
        void RemoveRangeByIds(IEnumerable<object> ids);

    }
}
