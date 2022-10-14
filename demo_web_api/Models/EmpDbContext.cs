using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace demo_web_api.Models
{
    public class EmpDbContext :DbContext 
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options):base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }


    }
}
