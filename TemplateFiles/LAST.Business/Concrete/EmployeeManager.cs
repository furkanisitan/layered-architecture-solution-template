using $ext_safeprojectname$.Business.Abstract;
using $ext_safeprojectname$.Business.ValidationRules.FluentValidation;
using $ext_safeprojectname$.Core.Aspect.Postsharp.ValidationAspects;
using $ext_safeprojectname$.DataAccess.Abstract;
using $ext_safeprojectname$.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace $safeprojectname$.Concrete
{
    class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public ICollection<Employee> GetAll(Expression<Func<Employee, bool>> filter = null) =>
            _employeeDal.GetAll(filter);

        public Employee GetById(int id) =>
            _employeeDal.Get(x => x.Id == id);

        [FluentValidationAspect(typeof(EmployeeValidator))]
        public Employee Add(Employee employee) =>
            _employeeDal.Add(employee);

        [FluentValidationAspect(typeof(EmployeeValidator))]
        public Employee Update(Employee employee) =>
            _employeeDal.Update(employee);

        public void DeleteById(int id) =>
            _employeeDal.Delete(new Employee { Id = id });
    }
}
