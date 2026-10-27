using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
