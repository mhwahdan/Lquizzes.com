using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Lquizzes.com.Controllers
{
    public class QuizController : Controller
    {
        public ActionResult Index()
        {
            ViewData["quizzes"] = MvcApplication.quizzes;
            return Redirect(Url.Content("~/"));
        }

        public ActionResult Examine(int? id)
        {
            if (id == null)
                return Index();
            ViewData["quiz"] = MvcApplication.quizzes.Find(x => x.id == (id ?? 0));
            return View();
        }


        public  JsonResult Submit(int quizid)
        {
            int score = 0;
            Quiz quiz = MvcApplication.quizzes.Find(x => x.id == quizid);
            foreach (Question question in quiz.questions)
            {
                string answer = Request.QueryString[question.question];
                if (string.Equals(answer, question.answers[question.correct]))
                    score += question.points;
            }

            //if (id == null)
                //return Json( new { success= false, responseText = "the quiz id must be submitted" } , JsonRequestBehavior.AllowGet);
            result result = new result();
            result.success = score >= quiz.success_score;
            result.grade = score;
            result.success_score = quiz.success_score;
            return Json(JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
    }
}