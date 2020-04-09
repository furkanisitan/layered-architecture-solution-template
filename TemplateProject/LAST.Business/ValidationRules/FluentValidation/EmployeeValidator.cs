using FluentValidation;
using LAST.Business.ValidationRules.FluentValidation.Abstract;
using LAST.Entities.Concrete;

namespace LAST.Business.ValidationRules.FluentValidation
{
    class EmployeeValidator : BaseValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Salary).GreaterThan(0);
            RuleFor(x => x.Fullname).NotEmpty();
        }
    }
}
