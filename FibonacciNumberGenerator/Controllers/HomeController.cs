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
            string ipAddress = GetIPAddress();
            userDAL.SaveUserInput(model.InputNumber, ipAddress);
            return View("Result", model);
        }

        public ActionResult DisplayUsers()
        {
            List<User> users = userDAL.DisplayUsers();
            return View("User", users);
        }

        private string GetIPAddress()
        {
            string ipAddress = string.Empty;
            if (Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {
                ipAddress = Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return ipAddress;
        }
    }
}