using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_ban_hang.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            //return RedirectToAction("Index", "LoginAdmin");
            return View("~/Areas/Admin/Views/Home/Index.cshtml");

        }
    }
}