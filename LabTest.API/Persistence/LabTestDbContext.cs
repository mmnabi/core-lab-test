using LabTest.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTest.API.Persistence
{
    public class LabTestDbContext : DbContext
    {
        public LabTestDbContext(DbContextOptions<LabTestDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
