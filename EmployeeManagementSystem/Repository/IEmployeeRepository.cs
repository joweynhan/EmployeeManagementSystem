using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee newEmployee);
        Employee UpdateEmployee(int employeeId, Employee newEmployee);
        Employee DeleteEmployee(int employeeId);
    }
}
