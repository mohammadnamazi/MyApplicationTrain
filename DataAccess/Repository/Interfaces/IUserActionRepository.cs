using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public interface IUserActionRepository : IRepository<User>
    {
        User GetfirstOrDefult(Expression<Func<User, bool>> filter);
        IEnumerable<User> GetAll();
        void Add(User entity);
        void Remove(User entity);
        void RemoveRange(User entity);
        void Update(User user);
    }
}
