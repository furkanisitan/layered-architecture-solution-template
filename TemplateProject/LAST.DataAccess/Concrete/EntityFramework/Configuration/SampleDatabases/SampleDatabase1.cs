using Bogus;
using LAST.Entities.Concrete;
using System.Data.Entity;

namespace LAST.DataAccess.Concrete.EntityFramework.Configuration.SampleDatabases
{
    class SampleDatabase1 : DropCreateDatabaseAlways<DatabaseContext>
    {
        public override void InitializeDatabase(DatabaseContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , $"ALTER DATABASE [{context.Database.Connection.Database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            base.InitializeDatabase(context);
        }

        protected override void Seed(DatabaseContext context)
        {

            // Add employees
            var employeeIds = 0;
            var employees = new Faker<Employee>()
                .RuleFor(x => x.Id, f => employeeIds++)
                .RuleFor(x => x.Salary, f => f.Random.Number(1500, 3000))
                .RuleFor(x => x.Fullname, f => f.Person.FullName);
            context.Employees.AddRange(employees.Generate(10));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
