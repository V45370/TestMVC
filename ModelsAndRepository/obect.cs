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
    
    public partial class obect
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public obect()
        {
            this.Prices = new HashSet<Price>();
        }
    
        public string Obect1 { get; set; }
        public string type { get; set; }
        public string adress { get; set; }
        public byte range { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual obect obect11 { get; set; }
        public virtual obect obect2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Price> Prices { get; set; }
    }
}