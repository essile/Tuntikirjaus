using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuntikirjaus.Models
{
    public static class DataAccess
    {
        private static TuntikirjausEntities db = new TuntikirjausEntities();
        public static List<Osasto> HaeOsastot()
        {
            return db.Osastot.ToList();
        }

        public static List<SelectListItem> HaeOsastoIdt()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            foreach(Osasto o in HaeOsastot())
            {
                lista.Add(new SelectListItem() { Text = o.nimi, Value = o.osasto_id.ToString() });
            }
            return lista;
        }

        internal static bool LisääHenkilö(Henkilo h)
        {
            db.Henkilot.Add(h);
            return db.SaveChanges() != 0;
        }

        public static List<SelectListItem> HaeProjektiIdt()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            foreach (Projekti p in db.Projektit)
            {
                lista.Add(new SelectListItem() { Text = p.nimi, Value = p.projekti_id.ToString() });
            }
            return lista;
        }

        public static bool LisaaTuntikirjaus(Tuntikirjaus t)
        {
            db.Tuntikirjaukset.Add(t);
            return db.SaveChanges() != 0;
        }

        public static List<SelectListItem> HaeHenkiloIdt()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            foreach (Henkilo p in db.Henkilot)
            {
                lista.Add(new SelectListItem() { Text = p.KokoNimi(), Value = p.henkilo_id.ToString() });
            }
            return lista;
        }
    }
}