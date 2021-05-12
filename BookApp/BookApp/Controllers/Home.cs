using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BookApp.Controllers
{
    public class Home : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Dont think this is th right way to go, but routing needs default index from homecontroller. Trying to remove error.
            // This is pure backend-api, and we dont need a frontend webpage
            return View();
        }
    }
}