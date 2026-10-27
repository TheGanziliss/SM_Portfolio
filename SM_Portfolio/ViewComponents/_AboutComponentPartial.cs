using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
