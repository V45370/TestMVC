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
    
    public partial class partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public partner()
        {
            this.Default_partner = new HashSet<Default_partner>();
        }
    
        public decimal Partner1 { get; set; }
        public string cPartnerName { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string EIK { get; set; }
        public string VAT { get; set; }
        public string IBAN { get; set; }
        public string Bank { get; set; }
        public string Tel { get; set; }
        public string email { get; set; }
        public string Place { get; set; }
        public string wid { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Default_partner> Default_partner { get; set; }
    }
}