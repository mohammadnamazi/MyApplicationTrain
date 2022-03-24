using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal ApplicationContext _context;
        internal DbSet<T> dbSet;

        public Repository(ApplicationContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }
        

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetfirstOrDefult(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
