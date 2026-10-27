using Microsoft.AspNetCore.Mvc;
using SM_Portfolio.DAL.Context;

namespace SM_Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = myPortfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
