using Microsoft.AspNetCore.Mvc;

namespace MVCHOT3.Controllers
{
	public class BowlingBallController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
