using $ext_safeprojectname$.Core.Entities;
using System.Linq;

namespace $safeprojectname$.DataAccess
{
    public interface IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
