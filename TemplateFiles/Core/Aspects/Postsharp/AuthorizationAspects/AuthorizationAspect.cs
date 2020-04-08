using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Linq;

namespace $safeprojectname$.Aspects.Postsharp.AuthorizationAspects
{
    /// <summary>
    /// Checks the authority required to run the method body.
    /// </summary>
    [PSerializable]
    public class AuthorizationAspect : OnMethodBoundaryAspect
    {
        private string[] _roles;

        public AuthorizationAspect(params string[] roles)
        {
            _roles = roles;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            if (_roles.All(x => !System.Threading.Thread.CurrentPrincipal.IsInRole(x)))
                throw new Exception("You are not authorized!");
        }
    }
}
