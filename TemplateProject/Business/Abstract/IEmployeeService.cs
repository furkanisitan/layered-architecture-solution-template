using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        ICollection<Employee> GetAll(Expression<Func<Employee, bool>> filter = null);
        Employee GetById(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        void DeleteById(int id);
    }
}
