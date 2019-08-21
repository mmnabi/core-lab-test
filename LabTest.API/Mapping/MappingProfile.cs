using AutoMapper;
using LabTest.API.Controllers.Resources;
using LabTest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTest.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<User, UserResource>();


            // Resource to Domain
            CreateMap<UserResource, User>();
        }
    }
}
