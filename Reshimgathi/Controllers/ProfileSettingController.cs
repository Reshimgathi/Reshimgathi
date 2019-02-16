using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reshimgathi.Controllers
{
    public class ProfileSettingController : Controller
    {
        // GET: ProfileSetting
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shortlisted()
        {
            return View();
        }

        public ActionResult Interested()
        {
            return View();
        }
    }
}