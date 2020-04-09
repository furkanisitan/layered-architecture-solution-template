using FluentValidation;
using $ext_safeprojectname$.Business.ValidationRules.FluentValidation.Abstract;
using $ext_safeprojectname$.Entities.Concrete;

namespace $safeprojectname$.ValidationRules.FluentValidation
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
