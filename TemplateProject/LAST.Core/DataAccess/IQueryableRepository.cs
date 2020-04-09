using LAST.Core.Entities;
using System.Linq;

namespace LAST.Core.DataAccess
{
    public interface IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
