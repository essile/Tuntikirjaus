using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuntikirjaus.Models
{
    public static class Ekstensiot    {

        public static string KokoNimi(this Henkilo h)
        {
            return h.sukunimi + ", " + h.etunimi;
        }
    }
}