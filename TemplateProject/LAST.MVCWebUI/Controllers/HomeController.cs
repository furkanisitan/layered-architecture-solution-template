using LAST.Business.Abstract;
using System.Web.Mvc;

namespace LAST.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Home
        public ActionResult Index()
        {
            // AuthenticationHelper.CreateAuthCookie()  => for login
            // FormsAuthentication.SignOut()            => for logout

            _employeeService.GetAll(); // for initialize database

            return View();
        }
    }
}