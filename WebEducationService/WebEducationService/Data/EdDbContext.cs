using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Models;

namespace WebEducationService.Data {
    public class EdDbContext : DbContext {
        public EdDbContext(DbContextOptions<EdDbContext> options) : base(options) { }

        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<StudentClassRel> StudentClassRels { get; set; }
        public DbSet<MajorClassRel> MajorClassRels { get; set; }

        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Student>(e => {
                e.ToTable("Students");
                e.Property(x => x.GPA).HasColumnType("decimal(9,2)");
            });
        }

        public DbSet<WebEducationService.Models.Instructor> Instructor { get; set; }
    }
}
