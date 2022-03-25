using DataAccess.Models;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserAction : Repository<User> , IUserActionRepository
    {

        public UserAction(ApplicationContext context) : base(context)
        {

        }

        public void Add(User entity)
        {
            _context.Add(entity);
        }

        

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetfirstOrDefult(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public  List<User> GetAllTask()
        {
            return _context.Users.ToList();
        }
    }
}
