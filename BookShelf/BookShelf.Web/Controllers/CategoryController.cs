using Microsoft.AspNetCore.Mvc;

namespace BookShelf.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
