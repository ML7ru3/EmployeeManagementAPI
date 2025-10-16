using EmployeeManagementAPI.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Entity
{
    public class ManagementContext : DbContext
    {
        /// <summary>
        /// 2 tables:
        /// - Employee
        /// - Department
        /// Note that you must Dipendency Injection this context
        /// in builder.Services (can create a class for this or
        /// edit in Program.cs)
        /// </summary>
         
        public DbSet<Employee> employees {  get; set; }
        public DbSet<Department> departments { get; set; }

        public ManagementContext(DbContextOptions<ManagementContext> options)
            : base(options)
        { 
        }
    }
}
