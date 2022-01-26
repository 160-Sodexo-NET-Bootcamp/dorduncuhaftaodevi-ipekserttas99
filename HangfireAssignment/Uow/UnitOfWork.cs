using AutoMapper;
using HangfireAssignment.Context;
using HangfireAssignment.Entity;
using HangfireAssignment.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDbContext context;
        private readonly IMapper _mapper;

        public UnitOfWork(StudentDbContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;

            Student = new GenericRepository<Student>(context, mapper);
        }

        public IGenericRepository<Student> Student { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
