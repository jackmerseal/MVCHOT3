using Microsoft.AspNetCore.Mvc;
using MVCHOT3.Models;
using System.Diagnostics;

namespace MVCHOT3.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}
	}
}