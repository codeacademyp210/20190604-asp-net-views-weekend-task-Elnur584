using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElsaWeekendTask.Controllers
{
    public class ComponentsController : Controller
    {
        // GET: Components
        public ActionResult ComponentIndex()
        {
            return View();
        }
    }
}