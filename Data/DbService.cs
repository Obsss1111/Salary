using Microsoft.EntityFrameworkCore;
using Salary.Models;

namespace Salary.Data
{
    public class DbService : DbContext
    {
        public DbService()
        {
        }

        public DbService (DbContextOptions<DbService> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Core Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Core Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Right> Right { get; set; }
        public DbSet<Firm> Firm { get; set; }
        public DbSet<Dep> Dep { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<WorkTimeEmployee> WorkTimeEmployee { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<ReportTemplate> ReportTemplate { get; set; }
        public DbSet<ReportType> ReportType { get; set; }
    }
}
