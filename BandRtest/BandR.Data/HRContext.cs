using BandR.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BandR.Data
{
    public class HRContext : DbContext
    {
        public HRContext() : base("HRContext")
        {
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
     
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Department>().ToTable("Departments");

            //modelBuilder.Entity<Employee>().HasRequired(e => e.Department).WithMany();

        }
      

    }
}