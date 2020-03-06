using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationTest.Models {
    public class EducationDbContext : DbContext {
        public EducationDbContext(DbContextOptions<EducationDbContext> options) : base(options) {}

        public DbSet<Major> Majors { get; set; }
    }
}
