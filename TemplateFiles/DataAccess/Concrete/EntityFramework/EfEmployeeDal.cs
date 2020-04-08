using Core.$safeprojectname$.EntityFramework;
using $safeprojectname$.Abstract;
using $safeprojectname$.Concrete.EntityFramework.Configuration;
using Entities.Concrete;

namespace $safeprojectname$.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, DatabaseContext>, IEmployeeDal
    {
    }
}
