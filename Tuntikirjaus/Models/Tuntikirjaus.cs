//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tuntikirjaus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tuntikirjaus
    {
        public int tuntikirjaus_id { get; set; }
        public int henkilo_id { get; set; }
        public int projekti_id { get; set; }
        public System.DateTime pvm { get; set; }
        public decimal tunnit { get; set; }
        public string kuvaus { get; set; }
        public bool laskutettava { get; set; }
    
        public virtual Henkilo Henkilo { get; set; }
        public virtual Projekti Projekti { get; set; }
    }
}
