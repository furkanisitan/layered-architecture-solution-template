using $ext_safeprojectname$.Business.Abstract;
using $ext_safeprojectname$.Business.Concrete;
using $ext_safeprojectname$.Core.DataAccess;
using $ext_safeprojectname$.Core.DataAccess.EntityFramework;
using $ext_safeprojectname$.DataAccess.Abstract;
using $ext_safeprojectname$.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace $safeprojectname$.DependencyResolvers.Ninject
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
