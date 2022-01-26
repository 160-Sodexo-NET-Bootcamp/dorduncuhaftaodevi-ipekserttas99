using Hangfire;
using HangfireAssignment.Entity;
using HangfireAssignment.Jobs;
using HangfireAssignment.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangfireController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddToTable([FromBody] StudentDTO student)
        {
            // create job'un nesnesini oluşturduk, içine student parametresini aldı
            CreateJob createJob = new(student);
            return Ok("Great! The job has been completed. Student added to db.");


        }

        [HttpGet]
        public IActionResult Get()
        {
            // update job'un nesnesini oluşturduk
            UpdateJob updateJob = new();
            return Ok("Great! The job has been completed. Status 'passive' updated to 'active'.");
        }

    }
}
