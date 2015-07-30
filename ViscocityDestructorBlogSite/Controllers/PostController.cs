using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViscocityDestructorBlogSite.Models;

namespace ViscocityDestructorBlogSite.Controllers
{
    public class PostController : Controller
    {
        private ProjectDB db = new ProjectDB();

        public ActionResult SavePost()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SavePost(FormCollection formCollection, string savePost, string saveAndPublish)
        {
            if (savePost != null)
            {
                //Session["userId"] = 1;
                Post aPost = new Post();
                aPost.Title = formCollection["Title"];
                aPost.Description = Server.HtmlDecode(formCollection["Description"]);
                aPost.PostDate = DateTime.Now;
                aPost.NoOfView = 0;
                aPost.UserID = 1;
                //aPost.UserID = (int)Session["userId"];
                aPost.IsPublished = false;
                db.Posts.Add(aPost);
                db.SaveChanges();
                return View();
            }
            if (saveAndPublish != null)
            {
                //Session["userId"] = 1;
                Post aPost = new Post();
                aPost.Title = formCollection["Title"];
                aPost.Description = Server.HtmlDecode(formCollection["Description"]);
                aPost.PostDate = DateTime.Now;
                aPost.NoOfView = 0;
                aPost.UserID = 1;
                //aPost.UserID = (int)Session["userId"];
                aPost.IsPublished = true;
                db.Posts.Add(aPost);
                db.SaveChanges();
                return View();
            }
            return View();
        }
    }
}