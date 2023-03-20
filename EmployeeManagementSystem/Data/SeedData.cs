using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace EmployeeManagementSystem.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
              new Department { Id = 1, Name = "Admin" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Joagne Fernando", DOB = DateTime.ParseExact("September 3, 2000", "MMMM d, yyyy", CultureInfo.InvariantCulture), Email = "joagneann@yahoo.com", Phone = "0976-083-9594", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Charles Jimenez", DOB = DateTime.ParseExact("July 16, 1999", "MMMM d, yyyy", CultureInfo.InvariantCulture), Email = "charles@gmail.com", Phone = "0956-234-3877", DepartmentId = 1 },
                new Employee { Id = 3, Name = "Janel Cubian", DOB = DateTime.ParseExact("January 16, 1990", "MMMM d, yyyy", CultureInfo.InvariantCulture), Email = "janel@yahoo.com", Phone = "0932-183-8300", DepartmentId = 1 });

        }
    }
}
