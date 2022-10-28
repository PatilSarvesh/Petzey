using Microsoft.AspNetCore.Mvc;

namespace Petzey.Controllers
{
    public class api : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
