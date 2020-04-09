using $ext_safeprojectname$.Core.DataAccess.EntityFramework;
using $ext_safeprojectname$.DataAccess.Abstract;
using $ext_safeprojectname$.DataAccess.Concrete.EntityFramework.Configuration;
using $ext_safeprojectname$.Entities.Concrete;

namespace $safeprojectname$.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, DatabaseContext>, IEmployeeDal
    {
    }
}
