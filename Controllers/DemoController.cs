using Microsoft.AspNetCore.Mvc;

namespace AspMvcCoreWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
