using Microsoft.AspNetCore.Mvc;
using SM_Portfolio.DAL.Context;

namespace SM_Portfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = MyPortfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
