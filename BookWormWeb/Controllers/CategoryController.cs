using Microsoft.AspNetCore.Mvc;

namespace BookWormWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
