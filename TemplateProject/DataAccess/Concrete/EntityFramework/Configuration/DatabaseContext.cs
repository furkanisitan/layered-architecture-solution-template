using DataAccess.Concrete.EntityFramework.Configuration.SampleDatabases;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework.Configuration
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
