using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }     
        public IActionResult Checkout()
        {
            return View();
        } 
        public IActionResult Cart()
        {
            return View();
        }


    }
}
