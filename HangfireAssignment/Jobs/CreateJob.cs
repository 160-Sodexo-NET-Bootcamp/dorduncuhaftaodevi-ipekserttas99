using Hangfire;
using HangfireAssignment.Entity;
using HangfireAssignment.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment.Jobs
{
    public class CreateJob
    {
        public IUnitOfWork unitOfWork;

        public CreateJob(StudentDTO student)
        {
           // Her 15dkda bir Student tablosuna Post Body'de girilen öğeleri atıyor
           RecurringJob.AddOrUpdate(() => unitOfWork.Student.Create(student), "*/15 * * * *");
        }

        

    }
}
