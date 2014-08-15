using System;
using PostsharpAndInjection.TheCode;
using System.Web.Mvc;

namespace PostsharpAndInjection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Click About to test.";

            return View();
        }

        [HandleException]
        public ActionResult About()
        {
            throw new Exception("Test exception");

            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
