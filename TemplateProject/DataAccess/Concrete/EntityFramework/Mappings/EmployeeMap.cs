using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Employees");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("EmployeeId");
            Property(x => x.Salary).IsRequired();
            Property(x => x.Fullname).IsRequired();
        }
    }
}
