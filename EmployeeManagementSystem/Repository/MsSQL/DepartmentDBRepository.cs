using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Repository.MsSQL
{
    public class DepartmentDBRepository : IDepartmentRepository
    {
        EmployeeDbContext _dbContext;

        public DepartmentDBRepository(EmployeeDbContext dbContext) //addscope for update
        {
            _dbContext = dbContext;
        }

        public Department AddDepartment(Department newDepartment)
        {
            _dbContext.Add(newDepartment);
            //CRUD operations you need to save the details --> commit
            _dbContext.SaveChanges();
            return newDepartment;
        }

        public Department DeleteDepartment(int departmentId)
        {
            var department = GetDepartmentById(departmentId);
            if (department != null)
            {
                _dbContext.Departments.Remove(department);
                _dbContext.SaveChanges();
            }
            return department;
        }

        public List<Department> GetAllDepartments()
        {
            return _dbContext.Departments.AsNoTracking().ToList(); //access the data from the database
        }
        public Department GetDepartmentById(int Id)
        {
            //keeps track of it, if any changes happen to the object we can save it automaticallly
            // discard the default behavior of the entity framework not to track
            return _dbContext.Departments.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public Department UpdateDepartment(int departmentId, Department newDepartment)
        {
            _dbContext.Departments.Update(newDepartment);
            _dbContext.SaveChanges();
            return newDepartment;
        }
    }
}
