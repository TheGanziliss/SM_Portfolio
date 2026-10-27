using Microsoft.AspNetCore.Mvc;
using SM_Portfolio.DAL.Context;

namespace SM_Portfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = myPortfolioContext.Messages.ToList();
            return View(values);
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = myPortfolioContext.Messages.Find(id);
            value.IsRead = true;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = myPortfolioContext.Messages.Find(id);
            value.IsRead = false;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = myPortfolioContext.Messages.Find(id);
            myPortfolioContext.Messages.Remove(value);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetail(int id)
        {
            var value = myPortfolioContext.Messages.Find(id);
            if (value == null)
                return RedirectToAction("Inbox");
            return View(value);
        }
    }
}
