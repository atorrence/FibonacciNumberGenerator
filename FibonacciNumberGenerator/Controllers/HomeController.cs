using System.Web.Mvc;
using FibonacciNumberGenerator.Models;
using FibonacciNumberGenerator.DAL;
using System.Collections.Generic;

namespace FibonacciNumberGenerator.Controllers
{
    public class HomeController : Controller
    {
        private IUserDAL userDAL;
        public HomeController(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }
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
            string ipAddress = Request.UserHostAddress;
            userDAL.SaveUserInput(model.InputNumber, ipAddress);
            return View("Result", model);
        }

        public ActionResult DisplayUsers()
        {
            List<User> users = userDAL.DisplayUsers();
            return View("User", users);
        }
    }
}