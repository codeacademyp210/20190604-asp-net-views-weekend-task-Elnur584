using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PastelWeekendTask.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult BlogIndex()
        {
            return View();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public ActionResult BlogElements()
        {
            return View();
        }
    }
}