using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
