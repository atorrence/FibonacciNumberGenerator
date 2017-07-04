using System.Web.Mvc;
using FibonacciNumberGenerator.Models;

namespace FibonacciNumberGenerator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult NewInput()
        {
            return View("NewInput");
        }

        public ActionResult Result(Result model)
        {
            return View("Result", model);
        }

        public ActionResult DisplayResults()
        {
            return View("Result");
        }
    }
}