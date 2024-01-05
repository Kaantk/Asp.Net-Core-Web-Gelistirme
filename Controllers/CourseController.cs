using Microsoft.AspNetCore.Mvc;
using PartProject_2.Models;

namespace PartProject_2.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Courses);
        }

        public IActionResult Details(int Id)
        {
            var course = Repository.GetById(Id);

            if (course != null)
            {
                return View(course);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}
