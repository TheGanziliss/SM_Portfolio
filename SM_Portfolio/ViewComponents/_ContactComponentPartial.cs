using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
