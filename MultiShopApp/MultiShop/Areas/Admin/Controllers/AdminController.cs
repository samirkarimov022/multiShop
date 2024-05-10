using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
