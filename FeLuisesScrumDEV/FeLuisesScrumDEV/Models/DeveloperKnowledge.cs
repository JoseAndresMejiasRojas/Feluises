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
    
    public partial class DeveloperKnowledge
    {
        public string idEmployeeFKPK { get; set; }
        public string devKnowledgePK { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
