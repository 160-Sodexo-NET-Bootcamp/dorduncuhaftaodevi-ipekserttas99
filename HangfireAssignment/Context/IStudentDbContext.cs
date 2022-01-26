using HangfireAssignment.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment.Context
{
    public interface IStudentDbContext
    {
        DbSet<Student> Student { get; set; }
        int SaveChanges();
    }
}
