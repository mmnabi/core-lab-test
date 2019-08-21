using AutoMapper;
using LabTest.API.Controllers.Resources;
using LabTest.API.Models;
using LabTest.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LabTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly LabTestDbContext context;
        private readonly IMapper mapper;

        public UsersController(LabTestDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<UserResource>> Get()
        {
            var users = await context.Users.ToListAsync();
            return mapper.Map<List<User>, List<UserResource>>(users);
        }
    }
}