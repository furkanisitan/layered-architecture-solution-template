using System.Linq;
using System.Threading;

namespace Business.ValidationRules.FluentValidation.HelperValidators
{
    static class HValidate
    {
        public static bool IsAuthorized(params string[] roles) =>
            roles.Any(x => Thread.CurrentPrincipal.IsInRole(x));
    }
}
