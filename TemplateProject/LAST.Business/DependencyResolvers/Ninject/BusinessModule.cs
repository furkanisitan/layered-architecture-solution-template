using LAST.Business.Abstract;
using LAST.Business.Concrete;
using LAST.Core.DataAccess;
using LAST.Core.DataAccess.EntityFramework;
using LAST.DataAccess.Abstract;
using LAST.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace LAST.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
        }
    }
}
