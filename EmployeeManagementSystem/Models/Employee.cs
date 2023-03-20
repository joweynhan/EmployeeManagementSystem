using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [DisplayName("Employee ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee's Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Employee's Date of Birth is Required")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Employee's Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [Required(ErrorMessage = "Employee's Phone is Required")]
        public string Phone { get; set; }
        public int? DepartmentId { get; set; } 
        public Department? Departments { get; set; } 
        public Employee()
        {

        }
        

        public Employee(int id, string name, DateTime dOB, string email, string phone, int? departmentId, Department departments)
        {
            Id = id;
            Name = name;
            DOB = dOB;
            Email = email;
            Phone = phone;
            DepartmentId = departmentId;
            Departments = departments;
        }
    }
}
