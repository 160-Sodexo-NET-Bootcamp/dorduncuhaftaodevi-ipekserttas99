using Hangfire;
using HangfireAssignment.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment.Jobs
{
    public class UpdateJob
    {
        public IUnitOfWork unitOfWork;

        public UpdateJob()
        {
            //Her gün saat 18:00'de status'u güncelliyor
            RecurringJob.AddOrUpdate(() => unitOfWork.Student.Update(), "00 15 * * *"); //00 15 yazıyor çünkü 00 18 yaptığımda  21:00'de başlatıyordu.
        }
    }
}
