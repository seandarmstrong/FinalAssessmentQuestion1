using FinalAssessmentQuestion1.Models;
using System.Web.Mvc;

namespace FinalAssessmentQuestion1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Result(NumberViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = model.Number1 + model.Number2;
                ViewBag.Result = result;
            }

            return View();
        }
    }
}