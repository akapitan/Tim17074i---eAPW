//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eAPW
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervacija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezervacija()
        {
            this.Rezervacija_has_Djelovi = new HashSet<Rezervacija_has_Djelovi>();
        }
    
        public int id { get; set; }
        public string kupacIme { get; set; }
        public string kupacPrezime { get; set; }
        public string kupacEmail { get; set; }
        public bool izvrseno { get; set; }
        public int napravioNarudzbu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija_has_Djelovi> Rezervacija_has_Djelovi { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
