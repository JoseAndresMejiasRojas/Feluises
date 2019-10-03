//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeLuisesScrumDEV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.Module = new HashSet<Module>();
            this.WorksIn = new HashSet<WorksIn>();
        }
        
        [Key]
        public int idProjectPK { get; set; }
        public string projectName { get; set; }
        public string objective { get; set; }
        public Nullable<decimal> estimatedCost { get; set; }
        public Nullable<decimal> realCost { get; set; }

        public Nullable<System.DateTime> startingDate { get; set; }
        public Nullable<System.DateTime> finishingDate { get; set; }
        public Nullable<decimal> budget { get; set; }
        public Nullable<int> estimatedDuration { get; set; }
        public string idClientFK { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Module> Module { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorksIn> WorksIn { get; set; }
    }
}
