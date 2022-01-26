using AutoMapper;
using HangfireAssignment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireAssignment
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentDTO, Student>();
        }
    }
}
