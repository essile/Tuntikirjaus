using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuntikirjaus.Models;

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
            ViewBag.Onnistui = null;
            ViewData["henkilo_id"] = DataAccess.HaeHenkiloIdt();
            ViewData["projekti_id"] = DataAccess.HaeProjektiIdt();

            return View();
        }

        [HttpPost]
        public ActionResult Tuntikirjaus(Models.Tuntikirjaus t)
        {
            ViewBag.Message = "Uusi tuntikirjaus";
            ViewBag.Onnistui = DataAccess.LisaaTuntikirjaus(t);
            
            ViewData["henkilo_id"] = DataAccess.HaeHenkiloIdt();
            ViewData["projekti_id"] = DataAccess.HaeProjektiIdt();

            return View();
        }

        public ActionResult UusiTyontekija()
        {            
            ViewBag.Message = "Uusi työntekijä";
            ViewData["osasto_id"] = DataAccess.HaeOsastoIdt();
            
            return View();
        }

        [HttpPost]
        public string UusiTyontekija(Henkilo h)
        {
            ViewBag.Message = "Uusi työntekijä";
            DataAccess.LisääHenkilö(h);

            return "Onnistui";
        }

        public ActionResult Raportti()
        {
            ViewBag.Message = "Tarkastele työtunteja";

            return View();
        }
    }
}