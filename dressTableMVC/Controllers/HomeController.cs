using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(){
        
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet ("/produtos")]
        public IActionResult produtos()
        {
            return View();
        }
    }
}
