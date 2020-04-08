using FluentValidation;

namespace $safeprojectname$.ValidationRules.FluentValidation.Abstract
{
    public class BaseValidator<T> : AbstractValidator<T>
    {
        static BaseValidator()
        {
            // Disables giving error messages by local language.
            ValidatorOptions.LanguageManager.Enabled = false;
        }
    }
}
