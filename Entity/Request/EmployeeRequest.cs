namespace EmployeeManagementAPI.Entity.Request
{
    public class EmployeeRequest
    {
        public int employeeId { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public string? position { get; set; }
        public DateOnly hireDate { get; set; }
        public int departmentId { get; set; }
    }
}
