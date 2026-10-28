using Microsoft.AspNetCore.Mvc;
using SM_Portfolio.DAL.Context;
using SM_Portfolio.DAL.Entities;

namespace SM_Portfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = myPortfolioContext.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            myPortfolioContext.ToDoLists.Add(toDoList);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = myPortfolioContext.ToDoLists.Find(id);
            myPortfolioContext.ToDoLists.Remove(value);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = myPortfolioContext.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            myPortfolioContext.ToDoLists.Update(toDoList);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusTrue(int id)
        {
            var value = myPortfolioContext.ToDoLists.Find(id);
            value.Status = true;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusFalse(int id)
        {
            var value = myPortfolioContext.ToDoLists.Find(id);
            value.Status = false;
            myPortfolioContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
