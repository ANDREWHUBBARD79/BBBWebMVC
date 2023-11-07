using BBBWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BBBWebMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult TShirts()
		{
			return View();
		}

		public IActionResult AreaRugs()
		{
			return View();
		}

		public IActionResult BathroomMats()
		{
			return View();
		}

		public IActionResult Blankets()
		{
			return View();
		}

		public IActionResult Contacts()
		{
			return View();
		}

		public IActionResult Cups()
		{
			return View();
		}

		public IActionResult Hats()
		{
			return View();
		}

		public IActionResult History()
		{
			return View();
		}

		public IActionResult Miscelanious()
		{
			return View();
		}

		public IActionResult Mugs()
		{
			return View();
		}

		public IActionResult PetBeds()
		{
			return View();
		}

		public IActionResult ShowerCurtains()
		{
			return View();
		}

		public IActionResult Sweatshirts()
		{
			return View();
		}

		public IActionResult TermsOfService()
		{
			return View();
		}

		public IActionResult WallPictures()
		{
			return View();
		}



		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}