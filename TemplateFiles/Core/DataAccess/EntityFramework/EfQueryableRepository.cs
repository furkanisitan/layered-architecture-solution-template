using $safeprojectname$.Entities;
using System.Data.Entity;
using System.Linq;

namespace $safeprojectname$.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        private readonly DbContext _context;
        private IDbSet<T> _entities;

        protected virtual IDbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());

        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => Entities;
    }
}
