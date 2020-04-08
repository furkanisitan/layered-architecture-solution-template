using System.Security.Principal;

namespace Core.CrossCuttingConcerns.Security.Principal
{
    public class Identity : IIdentity
    {
        public string Name { get; set; }
        public string AuthenticationType { get; set; }
        public bool IsAuthenticated { get; set; }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string[] Roles { get; set; }
    }
}
