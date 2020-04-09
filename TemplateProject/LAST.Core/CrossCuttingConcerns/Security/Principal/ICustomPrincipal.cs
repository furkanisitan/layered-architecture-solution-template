using System.Security.Principal;

namespace LAST.Core.CrossCuttingConcerns.Security.Principal
{
    public interface ICustomPrincipal : IPrincipal
    {
        int Id { get; }
        string Fullname { get; }
        string[] Roles { get; }
    }
}
