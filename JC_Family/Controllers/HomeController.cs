using JC_Family.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JC_Family.Controllers
{
    public class HomeController : Controller
    {
        private JC_FamilyDB db = new JC_FamilyDB();
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

        public ActionResult Search(string photoString)
        {
            var photos = db.Photos.Include("Creater").Where(a => a.Title.Contains(photoString)).Take(10);
            return View(photos);
        }
    }
}