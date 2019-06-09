using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElsaWeekendTask.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult BlogRightSideBar()
        {
            return View();
        }
        public ActionResult BlogSinglePost()
        {
            return View();
        }
        public ActionResult BlogNoSideBar()
        {
            return View();
        }
        public ActionResult BlogLeftSideBar()
        {
            return View();
        }
    }
}