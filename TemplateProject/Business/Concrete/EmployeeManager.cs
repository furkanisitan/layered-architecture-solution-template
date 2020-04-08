using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Postsharp.ValidationAspects;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
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
