using Microsoft.EntityFrameworkCore;
using StoraIcaButiken.Models;

namespace StoraIcaButiken.Data
{
    public class IcaButikenDbContext : DbContext
    {
        public IcaButikenDbContext(DbContextOptions<IcaButikenDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
