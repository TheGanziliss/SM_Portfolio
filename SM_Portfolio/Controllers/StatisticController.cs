using Microsoft.AspNetCore.Mvc;
using SM_Portfolio.DAL.Context;

namespace SM_Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = myPortfolioContext.Skills.Count();
            ViewBag.v2 = myPortfolioContext.Messages.Count();
            ViewBag.v3 = myPortfolioContext.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = myPortfolioContext.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
