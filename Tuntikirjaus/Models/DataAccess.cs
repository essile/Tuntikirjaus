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
    }
}