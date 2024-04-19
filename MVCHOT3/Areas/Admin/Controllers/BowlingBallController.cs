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

		[Route("[area]/bowlingballs/{brand?}/{slug?}")]
		public IActionResult List(string brand = "all")
		{
			List<BowlingBall> bowlingballs;

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

		[HttpGet]
		public IActionResult Add(int? id)
		{
			if (id.HasValue)
			{
				var bowlingball = _context.BowlingBalls.Find(id.Value);
				if (bowlingball != null)
				{
					return View("AddEdit", bowlingball);
				}
			}
			return View("AddEdit", new BowlingBall());
		}

		[HttpPost]
		public IActionResult Add(BowlingBall bowlingball)
		{
			if (ModelState.IsValid)
			{
				if (bowlingball.Id == 0)
				{
					_context.BowlingBalls.Add(bowlingball);
				}
				else
				{
					_context.BowlingBalls.Update(bowlingball);
				}

				_context.SaveChanges();
				return RedirectToAction("List");
			}

			return View("AddEdit", bowlingball);
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var bowlingball = _context.BowlingBalls.Find(id);
			if (bowlingball != null)
			{
				return View(bowlingball);
			}
			return RedirectToAction("List");
		}

		[HttpPost]
		public IActionResult DeleteBowlingBall(int id)
		{
			var bowlingball = _context.BowlingBalls.Find(id);
			if (bowlingball != null)
			{
				_context.BowlingBalls.Remove(bowlingball);
				_context.SaveChanges();
			}
			return RedirectToAction("List");
		}
	}
} 