using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lquizzes.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["quizzes"] = MvcApplication.quizzes;
            return View();
        }

        public ActionResult StartQuiz(int id)
        {
            
            return RedirectToRoute("Quizzes", new { Id = 5 });
        }
    }
}