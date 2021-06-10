using StudyPlanWeb.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyPlanWeb.Controllers
{
    public class LoginController : Controller
    {
        MyContext db;

        public ActionResult Index()
        {
            db = new MyContext();
            return View();
        }

        public ActionResult Login(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Login == username);
            return View((user?.CheckPassword(password) ?? false) ? user : null);
        }
    }
}