using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
