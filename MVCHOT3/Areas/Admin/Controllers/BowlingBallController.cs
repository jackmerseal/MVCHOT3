using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCHOT3.Models;

namespace MVCHOT3.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BowlingBallController : Controller
	{
		private readonly ShopContext _context;

		public BowlingBallController(ShopContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
