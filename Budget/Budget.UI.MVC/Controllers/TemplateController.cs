using Microsoft.AspNetCore.Mvc;

namespace Budget.UI.MVC.Controllers
{
	public class TemplateController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Buttons()
		{
			return View();
		}

        public IActionResult Cards()
        {
            return View();
        }

        public IActionResult Color()
        {
            return View();
        }
    }
}
