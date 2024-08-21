using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class DefoultController : Controller
    {
        public IActionResult Index()
        {           
            return View();
        }
    }
}
