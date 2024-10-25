using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models.Repository.IRepository;
using System.Linq.Expressions;


namespace Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
            _db.JobApplications.Include(u => u.Tag).Include(u => u.TagId);

        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }


        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }



        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
        public void RemoveById(object id)
        {
            T entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
        public void RemoveRangeByIds(IEnumerable<object> ids)
        {
            foreach (var id in ids)
            {
                T entity = dbSet.Find(id);
                if (entity != null)
                {
                    dbSet.Remove(entity);
                }
            }
        }


    }
}