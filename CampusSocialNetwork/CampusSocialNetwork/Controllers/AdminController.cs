using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampusSocialNetwork.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddClass()
        {
            return View();
        }
        public ActionResult AddTeacher()
        {
            return View();
        }

    }
}