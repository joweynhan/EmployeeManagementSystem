using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //
        {
            string connectionString = @"Server = COLLABPH1001998;Database=EMS;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDefaultData();
            base.OnModelCreating(modelBuilder);
        }
      
        public DbSet<Employee> Employees { get; set; } //public - to migrate, magagamit ang tb sa ibang pages
        public DbSet<Department> Departments { get; set; }
    }
}
