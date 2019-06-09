using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElsaWeekendTask.Controllers
{
    public class PageLayoutsController : Controller
    {
        // GET: PageLayouts
        public ActionResult FullWidth()
        {
            return View();
        }
        public ActionResult RightSideBar()
        {
            return View();
        }
        public ActionResult LeftSideBar()
        {
            return View();
        }
        public ActionResult RightLeftSideBar()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
    }
}