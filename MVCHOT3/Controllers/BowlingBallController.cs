using Microsoft.AspNetCore.Mvc;
using MVCHOT3.Models;
using MVCHOT3.Models.DataLayer;

namespace MVCHOT3.Controllers
{
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

		[Route("bowlingballs/{brand?}")]
		public IActionResult List(string brand = "all")
		{
			List<BowlingBall>bowlingballs;
			if (brand.Equals("all"))
			{
				bowlingballs = _context.BowlingBalls.ToList();
			}
			else
			{
				bowlingballs = _context.BowlingBalls.Where(b => b.Brand == brand).ToList();
			}
			return View(bowlingballs);
		}

		[Route("bowlingball/{id}/{slug?}")]
		public IActionResult Details(int id)
		{
			var bowlingball = _context.BowlingBalls.Find(id);
			if (bowlingball != null && bowlingball.ImageFileName != null)
			{
				bowlingball.ImageFileName = "/images/" + bowlingball.ImageFileName;
			}
			return View(bowlingball);
		}
	}
}