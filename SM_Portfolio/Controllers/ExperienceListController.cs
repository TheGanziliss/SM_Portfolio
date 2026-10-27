using Microsoft.AspNetCore.Mvc;
using SM_Portfolio.DAL.Context;
using SM_Portfolio.DAL.Entities;

namespace SM_Portfolio.Controllers
{
    public class ExperienceListController : Controller
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = myPortfolioContext.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            myPortfolioContext.Experiences.Add(experience);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = myPortfolioContext.Experiences.Find(id);
            myPortfolioContext.Experiences.Remove(value);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }


        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = myPortfolioContext.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            myPortfolioContext.Experiences.Update(experience);
            myPortfolioContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
