using Microsoft.AspNetCore.Mvc;

namespace VivesBlog.Controllers
{
	public class Articles : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
