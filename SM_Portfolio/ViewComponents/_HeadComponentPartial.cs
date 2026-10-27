using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
