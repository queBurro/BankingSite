using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingSite.Controllers
{
    public class HelpController : Controller
    {
        // GET: Help
        public ActionResult Index()
        {
            return View("Bonus");//this returns the Help view
        }

        public string SomethingAgain()
        {
            return "Help controller says hello";
        }
    }
}