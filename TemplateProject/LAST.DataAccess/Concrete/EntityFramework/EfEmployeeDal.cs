using LAST.Core.DataAccess.EntityFramework;
using LAST.DataAccess.Abstract;
using LAST.DataAccess.Concrete.EntityFramework.Configuration;
using LAST.Entities.Concrete;

namespace LAST.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, DatabaseContext>, IEmployeeDal
    {
    }
}
