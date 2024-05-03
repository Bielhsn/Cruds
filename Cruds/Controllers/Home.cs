using Microsoft.AspNetCore.Mvc;

namespace Cruds.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
