using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTWProject.Areas.Admin.Controllers
{
    public class DasboardController : Controller
    {
        // GET: Admin/Dasboard
        public ActionResult Index()
        {
            return View();
        }
    }
}