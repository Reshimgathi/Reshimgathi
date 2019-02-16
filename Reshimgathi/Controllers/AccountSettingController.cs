using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reshimgathi.Controllers
{
    public class AccountSettingController : Controller
    {
        // GET: AccountSetting
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VerifyMobile()
        {
            return View();
        }

        public ActionResult VerifyEmail()
        {
            return View();
        }
    }
}