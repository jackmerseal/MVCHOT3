using Microsoft.AspNetCore.Mvc;

namespace MVCHOT3.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
