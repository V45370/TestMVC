//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelsAndRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class artikul
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artikul()
        {
            this.document_detail = new HashSet<document_detail>();
            this.Prices = new HashSet<Price>();
            this.stokas = new HashSet<stoka>();
        }
    
        public decimal id { get; set; }
        public string Artikul1 { get; set; }
        public string Vid { get; set; }
        public string podwid { get; set; }
        public decimal defprice { get; set; }
        public string author { get; set; }
        public string info1 { get; set; }
        public string info2 { get; set; }
        public string Proizvoditel { get; set; }
        public System.Guid rowguid13 { get; set; }
        public bool isMultiPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<document_detail> document_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Price> Prices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stoka> stokas { get; set; }
    }
}