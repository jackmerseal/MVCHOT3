﻿using Microsoft.AspNetCore.Mvc;

namespace MVCHOT3.Areas.Admin.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
