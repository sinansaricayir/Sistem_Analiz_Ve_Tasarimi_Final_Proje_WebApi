//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETicaret_WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            this.Kayit = new HashSet<Kayit>();
            this.Sepet = new HashSet<Sepet>();
            this.Sepet2 = new HashSet<Sepet2>();
        }
    
        public int urunId { get; set; }
        public string urunAd { get; set; }
        public decimal urunFiyat { get; set; }
        public string urunGorsel { get; set; }
        public string urunAciklama { get; set; }
        public int urunKatId { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayit> Kayit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sepet> Sepet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sepet2> Sepet2 { get; set; }
    }
}