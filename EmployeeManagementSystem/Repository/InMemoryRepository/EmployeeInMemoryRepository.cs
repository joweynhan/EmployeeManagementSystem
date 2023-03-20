using EmployeeManagementSystem.Models;
using System.Globalization;

namespace EmployeeManagementSystem.Repository.InMemoryRepository
{
    public class EmployeeInMemoryRepository : IEmployeeRepository
    {
        static List<Employee> employeeList = new List<Employee>();

        static EmployeeInMemoryRepository()
        {
                employeeList.Add(new Employee(1, "Adrian Alejo", DateTime.ParseExact("September 3, 2000", "MMMM d, yyyy", CultureInfo.InvariantCulture), "joagneann@yahoo.com", "0976-083-9594", 1, new Department(1, "IT")));
                employeeList.Add(new Employee(2, "Justin Dela Rapa", DateTime.ParseExact("July 16, 1999", "MMMM d, yyyy", CultureInfo.InvariantCulture), "charles@gmail.com", "0956-234-3877", 2, new Department(2, "Marketing")));
                employeeList.Add(new Employee(3, "John Doe", DateTime.ParseExact("January 16, 1990", "MMMM d, yyyy", CultureInfo.InvariantCulture), "janel@yahoo.com", "0932-183-8300", 3, new Department(3, "HR")));
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeList;
        }
        //get any specific employee
        public Employee GetEmployeeById(int Id)
        {
            return employeeList.FirstOrDefault(x => x.Id == Id);
        }
        //add employee into the list
        public Employee AddEmployee(Employee newEmployee)
        {
            if (employeeList.Count == 0)
            {
                newEmployee.Id = 1;
            }
            else
            {
                newEmployee.Id = employeeList.Max(x => x.Id) + 1;
            }
            employeeList.Add(newEmployee);
            return newEmployee;
        }
        //delete
        public Employee DeleteEmployee(int employeeId)
        {
            var oldEmployee = employeeList.Find(x => x.Id == employeeId);
            if (oldEmployee == null)
                return null;
            employeeList.Remove(oldEmployee);
            return oldEmployee;
        }

        //update
        public Employee UpdateEmployee(int employeeId, Employee newEmployee)
        {
            var oldEmployee = employeeList.Find(x => x.Id == employeeId);
            if (oldEmployee == null)
                return null;
            employeeList.Remove(oldEmployee);
            employeeList.Add(newEmployee);
            return newEmployee;
        }

        public List<Employee> GetAllemployees()
        {
            throw new NotImplementedException();
        }
    }
}
