using AutoMapper;
using Dapper;
using HangfireAssignment.Context;
using HangfireAssignment.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HangfireAssignment.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected StudentDbContext context;
        internal DbSet<T> dbSet;
        private readonly IMapper _mapper;
        public GenericRepository(StudentDbContext context, IMapper mapper)
        {
            this.context = context;
            dbSet = context.Set<T>();
            _mapper = mapper;
        }

        public async Task<bool> Create(StudentDTO student)
        {
            var s = new Student { Name=student.Name, Surname=student.Surname, Status=student.Status};
            s = _mapper.Map<Student>(s);

            context.Student.Add(s);
            context.SaveChanges();

            return true;
        }

         public async Task<bool> Update()
        {
            var v = context.Student.ToList();
            foreach (var item in v)
            {
                item.Status= "Active";
            }
            context.SaveChanges();

            return true;
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).AsQueryable();
        }

       
    }
}
