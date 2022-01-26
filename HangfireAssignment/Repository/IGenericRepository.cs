using HangfireAssignment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> Create(StudentDTO student);
        Task<bool> Update();
        IEnumerable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> where);
    }
}
