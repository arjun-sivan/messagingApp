using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Context
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
