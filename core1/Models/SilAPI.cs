using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core1.Models
{
    public class SilAPI:DbContext
    {
        public SilAPI(DbContextOptions<SilAPI> options)
            : base(options)
        {
        }

        public DbSet<SilAPI> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SilAPI>().ToTable("Course");
        }
    }
}
