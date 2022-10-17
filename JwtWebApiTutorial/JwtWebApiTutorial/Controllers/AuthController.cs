using Microsoft.AspNetCore.Mvc;

namespace JwtWebApiTutorial.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
