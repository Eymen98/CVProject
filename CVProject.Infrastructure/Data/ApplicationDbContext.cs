using CVProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Infrastructure.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
