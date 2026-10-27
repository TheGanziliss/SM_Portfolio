using Microsoft.AspNetCore.Mvc;

namespace SM_Portfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
