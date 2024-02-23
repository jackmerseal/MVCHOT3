using Microsoft.AspNetCore.Mvc;
using MVCHOT3.Models;
using Microsoft.AspNetCore.Http;

namespace MVCHOT3.Controllers
{
	public class ShoppingCartController : Controller
	{
		private readonly ShopContext _context;
		private List<ShoppingCartItem> _cartItems;

		public ShoppingCartController(ShopContext context)
		{
			_context = context;
			_cartItems= new List<ShoppingCartItem>();
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AddToCart(int id)
		{
			var bowlingBallToAdd = _context.BowlingBalls.Find(id);
			var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();
			var existingCartItem = cartItems.FirstOrDefault(item => item.BowlingBall.Id == id);

			if (existingCartItem != null)
			{
				existingCartItem.Quantity++;
			}
			else
			{
				cartItems.Add(new ShoppingCartItem
				{
					BowlingBall = bowlingBallToAdd,
					Quantity = 1
				});
			}

			HttpContext.Session.Set("Cart", cartItems);
			TempData["CartMessage"] = $"{bowlingBallToAdd.Brand} {bowlingBallToAdd.Name} added to cart";
			return RedirectToAction("ViewCart");
		}

		public IActionResult ViewCart()
		{
			var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();
			var cartViewModel = new ShoppingCartViewModel
			{
				CartItems = cartItems,
				TotalPrice = cartItems.Sum(item => item.BowlingBall.Price * item.Quantity)
			};

			ViewBag.CartMessage = TempData["CartMessage"];
			return View(cartViewModel);
		}

		public IActionResult RemoveItem(int id)
		{
			var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();
			var itemToRemove = cartItems.FirstOrDefault(item => item.BowlingBall.Id == id);
			TempData["CartMessage"] = $"{itemToRemove.BowlingBall.Brand} {itemToRemove.BowlingBall.Name} Removed From Cart";
			if (itemToRemove != null)
			{
				if (itemToRemove.Quantity > 1)
				{
					itemToRemove.Quantity--;
				}
				else
				{
					cartItems.Remove(itemToRemove);
				}
			}

			HttpContext.Session.Set("Cart", cartItems);
			return RedirectToAction("ViewCart");
		}

		[HttpPost]
		public IActionResult PurchaseItems()
		{
			var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();
			foreach (var item in cartItems)
			{
				_context.Purchases.Add(new Purchase
				{
					BowlingBallId = item.BowlingBall.Id,
					Quantity = item.Quantity,
					PurchaseDate = DateTime.Now,
					Total = item.BowlingBall.Price * item.Quantity
				});
			}
			_context.SaveChanges();
			HttpContext.Session.Set("Cart", new List<ShoppingCartItem>());
			return RedirectToAction("Index", "Home");
		}
	}
} 
