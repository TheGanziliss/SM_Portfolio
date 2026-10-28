using Microsoft.AspNetCore.Mvc;
using SM_Portfolio.DAL.Context;

namespace SM_Portfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = myPortfolioContext.ToDoLists.Where(x => x.Status == false).Count();
            var values = myPortfolioContext.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
