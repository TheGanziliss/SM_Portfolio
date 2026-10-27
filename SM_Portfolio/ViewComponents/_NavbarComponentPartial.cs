using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
