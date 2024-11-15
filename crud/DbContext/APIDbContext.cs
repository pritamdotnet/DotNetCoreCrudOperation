using Microsoft.EntityFrameworkCore;
using crud.Model;

namespace crud.Model
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }
        public DbSet<Department> Departments
        {
            get;
            set;
        }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
    }


}
