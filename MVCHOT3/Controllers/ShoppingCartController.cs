using Microsoft.AspNetCore.Mvc;

namespace MVCHOT3.Controllers
{
	public class ShoppingCartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
