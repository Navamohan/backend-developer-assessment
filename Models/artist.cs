//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SearchApiService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class artist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artist()
        {
            this.artistalias = new HashSet<artistalia>();
            this.artistreleases = new HashSet<artistrelease>();
        }
    
        public int id { get; set; }
        public System.Guid globalid { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> begindate { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
        public string artisttype { get; set; }
        public string gender { get; set; }
        public string country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<artistalia> artistalias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<artistrelease> artistreleases { get; set; }
    }
}
