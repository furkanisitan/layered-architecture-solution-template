using LAST.Core.CrossCuttingConcerns.Security.Principal;
using System.Web.Security;

namespace LAST.Core.CrossCuttingConcerns.Security.Web
{
    public static class SecurityUtilities
    {
        /// <summary>
        /// Converts ticket to identity.
        /// </summary>
        public static Identity FormsAuthenticationTicketToIdentity(FormsAuthenticationTicket ticket)
        {
            var tags = ticket.UserData.Split('|');

            return new Identity
            {
                Name = ticket.Name,
                AuthenticationType = nameof(FormsAuthentication),
                IsAuthenticated = true,
                Fullname = tags[0],
                Id = int.Parse(tags[1]),
                Roles = tags[2].Split(',')
            };
        }
    }
}
