namespace FeLuisesScrumDEV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Module()
        {
            this.Requeriment = new HashSet<Requeriment>();
        }
    
        [Key]
        public int idProjectFKPK { get; set; }
        [Key]
        public int idModulePK { get; set; }
        [MaxLength(30,ErrorMessage ="El nombre de un m�dulo no debe de ser de m�s de 30 caracteres.")]
        [Required(ErrorMessage = "Debe de especificar un nombre.")]
        public string name { get; set; }
    
        public virtual Project Project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requeriment> Requeriment { get; set; }
    }
}
