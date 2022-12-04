using HOL6.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HOL6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult GetServerTime()
        {
            System.Threading.Thread.Sleep(5000);
            return PartialView();
        }
        static List<user> users = new List<user>();
        public ActionResult GetAllUsers()
        {
            return PartialView(users);
        }
        public ActionResult CreateUser()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateUser(user u )
        {
            users.Add(u);
            return RedirectToAction("GetAllUsers");
        }












    }



}