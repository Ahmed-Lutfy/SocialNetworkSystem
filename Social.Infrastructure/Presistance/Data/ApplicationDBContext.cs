using Microsoft.EntityFrameworkCore;
using Social.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Social.Infrastructure.Presistance.Data
{
   public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }

        //public DbSet<Movie> Movies => Set<Movie>();
        //public DbSet<Category> Categories => Set<Category>();
        //public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Automatically apply all configuration classes in this assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // OR --------------------------------------------------------------------------------
          // modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

       public DbSet<Post> posts { get; set; }
    }
}
