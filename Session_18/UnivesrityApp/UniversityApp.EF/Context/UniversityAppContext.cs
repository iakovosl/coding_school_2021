using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.EF.Configuration;
using UniversityApp.Model;

namespace UniversityApp.EF.Context {
    class UniversityAppContext: DbContext {

        protected UniversityAppContext() : base() { }
        public UniversityAppContext(DbContextOptions options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IAKOVOS;Database=AdventureWorks2019;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new UniversityConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
    }

   
}
