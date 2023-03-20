using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository.InMemoryRepository
{
    public class DepartmentInMemoryRepository : IDepartmentRepository
    {
        static List<Department> departmentList = new List<Department>();

        static DepartmentInMemoryRepository()
        {
            departmentList.Add(new Department(1, "IT"));
            departmentList.Add(new Department(2, "Marketing"));
            departmentList.Add(new Department(3, "HR"));
            departmentList.Add(new Department(4, "Accounting"));
            departmentList.Add(new Department(5, "Sales"));
        }
        public List<Department> GetAllDepartments()
        {
            return departmentList;
        }
        //getting any specific department
        public Department GetDepartmentById(int Id)
        {
            return departmentList.FirstOrDefault(x => x.Id == Id);
        }

        //add department into the list
        public Department AddDepartment(Department newDepartment)
        {
            if (departmentList.Count == 0)
            {
                newDepartment.Id = 1;
            }
            else
            {
                newDepartment.Id = departmentList.Max(x => x.Id) + 1;
            }
            departmentList.Add(newDepartment);
            return newDepartment;
        }

        //update department in the list
        public Department UpdateDepartment(int departmentId, Department newDepartment)
        {
            var oldDepartment = departmentList.Find(x => x.Id == departmentId);
            if (oldDepartment == null)
                return null;
            departmentList.Remove(oldDepartment);
            departmentList.Add(newDepartment);
            return newDepartment;
        }

        //delete
        public Department DeleteDepartment(int departmentId)
        {
            var oldDepartment = departmentList.Find(x => x.Id == departmentId);
            if (oldDepartment == null)
                return null;
            departmentList.Remove(oldDepartment);
            return oldDepartment;
        }
    }
}

