using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuntikirjaus.Controllers
{
    public class TuntikirjausController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Tuntikirjaus()
        {
            ViewBag.Message = "Uusi tuntikirjaus";

            return View();
        }

        public ActionResult UusiTyontekija()
        {
            ViewBag.Message = "Uusi työntekijä";

            return View();
        }

        public ActionResult Raportti()
        {
            ViewBag.Message = "Tarkastele työtunteja";

            return View();
        }
    }
}