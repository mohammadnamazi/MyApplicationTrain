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
    public class UserAction : Repository<Person>, IUserActionRepository
    {

        public UserAction(ApplicationContext context) : base(context)
        {

        }

        public void Add(Person entity)
        {
            _context.Add(entity);
        }



        public IEnumerable<Person> GetAll()
        {
            return _context.Persons;
        }

        public Person GetfirstOrDefult(Expression<Func<Person, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            var user = _context.Persons.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _context.Persons.Remove(user);
            }
        }

        public void RemoveRange(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Person user)
        {
            _context.Persons.Update(user);
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

        public List<Person> GetAllTask()
        {
            return _context.Persons.ToList();
        }
    }
}
