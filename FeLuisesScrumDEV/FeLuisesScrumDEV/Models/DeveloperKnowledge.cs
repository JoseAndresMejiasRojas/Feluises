//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeLuisesScrumDEV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DeveloperKnowledge
    {
        [Required(ErrorMessage = "Selecciona algun empleado*")]
        public string idEmployeeFKPK { get; set; }
        [MaxLength(30, ErrorMessage = "El conocimiento no debe de poseer más de 30 caracteres")]
        [Required(ErrorMessage = "Campo obligatorio, debe de ingresar el conocimiento*")]
        public string devKnowledgePK { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
