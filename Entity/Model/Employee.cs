using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementAPI.Entity.Model
{
    public class Employee
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public DateOnly HireDate { get; set; }
        public int DepartmentId { get; set; }
    }
}
