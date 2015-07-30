using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViscocityDestructorBlogSite.Models;

namespace ViscocityDestructorBlogSite.Controllers
{
    public class HomeController : Controller
    {
        private ProjectDB db = new ProjectDB();
        public ActionResult Index()
        {

            ViewBag.List2 = db.Posts.OrderByDescending(d => d.NoOfView).Take(2).ToList();
            var list = db.Posts.OrderByDescending(d => d.PostDate).Take(2);
            return View(list.ToList());
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
      
    }
}