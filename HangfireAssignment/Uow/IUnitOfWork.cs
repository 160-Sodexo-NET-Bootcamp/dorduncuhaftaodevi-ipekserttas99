using HangfireAssignment.Entity;
using HangfireAssignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment.Uow
{
    public interface IUnitOfWork
    {
        IGenericRepository<Student> Student { get; }
        int Complete();
    }
}
