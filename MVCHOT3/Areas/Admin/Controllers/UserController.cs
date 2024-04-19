using Microsoft.AspNetCore.Mvc;

namespace MVCHOT3.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
