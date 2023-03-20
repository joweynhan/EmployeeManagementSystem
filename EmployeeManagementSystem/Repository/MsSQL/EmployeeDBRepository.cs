using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Repository.MsSQL
{
    public class EmployeeDBRepository : IEmployeeRepository
    {
        EmployeeDbContext _dbContext;

        public EmployeeDBRepository(EmployeeDbContext dbContext) //addscope for update
        {
            _dbContext = dbContext;
        }

        public Employee AddEmployee(Employee newEmployee)
        {
            _dbContext.Add(newEmployee);
            //CRUD operations you need to save the details --> commit
            _dbContext.SaveChanges();
            return newEmployee;
        }

        public Employee DeleteEmployee(int employeeId)
        {
            var employee = GetEmployeeById(employeeId);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.AsNoTracking().ToList(); //access the data from the database
        }
        public Employee GetEmployeeById(int Id)
        {
            //keeps track of it, if any changes happen to the object we can save it automaticallly
            // discard the default behavior of the entity framework not to track
            return _dbContext.Employees.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public Employee UpdateEmployee(int employeeId, Employee newEmployee)
        {
            _dbContext.Employees.Update(newEmployee);
            _dbContext.SaveChanges();
            return newEmployee;
        }
    }
}
