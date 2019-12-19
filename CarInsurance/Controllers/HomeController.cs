using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if(string.IsNullOrEmpty(firstName)|| string.IsNullOrEmpty(lastName)|| string.IsNullOrEmpty(emailAddress))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            return View();
        }
    }
}