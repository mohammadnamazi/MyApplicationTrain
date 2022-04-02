using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public interface IUserActionRepository : IRepository<Person>
    {
        Person GetfirstOrDefult(Expression<Func<Person, bool>> filter);
        IEnumerable<Person> GetAll();
        List<Person> GetAllTask();

        void Add(Person entity);
        void Remove(int id );
        void RemoveRange(Person entity);
        void Update(Person user);
    }
}
