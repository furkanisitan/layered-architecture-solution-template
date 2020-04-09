using $ext_safeprojectname$.DataAccess.Concrete.EntityFramework.Configuration.SampleDatabases;
using $ext_safeprojectname$.DataAccess.Concrete.EntityFramework.Mappings;
using $ext_safeprojectname$.Entities.Concrete;
using System.Data.Entity;

namespace $safeprojectname$.Concrete.EntityFramework.Configuration
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new SampleDatabase1());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
        }
    }
}
