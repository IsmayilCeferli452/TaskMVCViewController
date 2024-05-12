using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetName()
        {
            return View();
        }
        
    }
}
