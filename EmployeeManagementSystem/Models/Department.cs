using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        //[DisplayName("Department ID")]
        [Required(ErrorMessage = "Department Name is Required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Department Name is Required")]
        [MinLength(2)]
        public string Name { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; } //pagcollect ng laman ng employee

        public Department()
        {

        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }


    }
}
