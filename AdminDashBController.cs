using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientManagement.Controllers
{
    public class AdminDashBController : Controller
    {
        // GET: AdminDashB
        public ActionResult AdminHome()
        {
            return View();
        }
    }
}