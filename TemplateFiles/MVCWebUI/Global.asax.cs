using Business.DependencyResolvers.Ninject;
using Core.CrossCuttingConcerns.Security.Principal;
using Core.CrossCuttingConcerns.Security.Web;
using Core.Utilities.MVC.Infrastructure;
using System;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace $safeprojectname$
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
        }

        public override void Init()
        {
            PostAuthenticateRequest += MvcApplication_PostAuthenticateRequest;
            base.Init();
        }

        private void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {
            try
            {
                var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                if (authCookie == null) return;

                var encTicket = authCookie.Value;
                if (string.IsNullOrEmpty(encTicket)) return;

                var ticket = FormsAuthentication.Decrypt(encTicket);
                var identity = SecurityUtilities.FormsAuthenticationTicketToIdentity(ticket);
                var principal = new CustomPrincipal(identity);

                HttpContext.Current.User = principal;   // for Web
                Thread.CurrentPrincipal = principal;    // for Back-end
            }
            catch
            {
                // ignored
            }
        }
    }
}
