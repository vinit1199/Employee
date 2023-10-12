using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Skills { get; set; }

        public int DepartmentId { get; set; }

        public string Department { get; set; }
    }
}
