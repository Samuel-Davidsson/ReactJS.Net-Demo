using ReactDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<CommentModel> comments;
        static HomeController()
        {
            comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                },
            };
        }
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        //[OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult Comments()
        {
            return Json(comments, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddComment(CommentModel comment)
        {
            comment.Id = comments.Count + 1;
            comments.Add(comment);
            return Content("Success :)");
        }

    }
}