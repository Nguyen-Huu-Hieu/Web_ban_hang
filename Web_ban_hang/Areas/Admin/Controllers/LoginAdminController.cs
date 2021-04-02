using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_ban_hang.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: Admin/LoginAdmin
        public ActionResult Index()
        {
            return View("LoginAdmin");
        }

        public ActionResult Logout()
        {
            return View("~/Areas/Admin/Views/LoginAdmin/LoginAdmin.cshtml");

        }
    }
}