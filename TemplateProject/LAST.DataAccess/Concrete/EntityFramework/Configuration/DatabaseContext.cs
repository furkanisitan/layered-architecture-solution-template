using LAST.DataAccess.Concrete.EntityFramework.Configuration.SampleDatabases;
using LAST.DataAccess.Concrete.EntityFramework.Mappings;
using LAST.Entities.Concrete;
using System.Data.Entity;

namespace LAST.DataAccess.Concrete.EntityFramework.Configuration
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
