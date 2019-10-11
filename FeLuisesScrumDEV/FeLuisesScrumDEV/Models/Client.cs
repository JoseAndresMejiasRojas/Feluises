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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Project = new HashSet<Project>();
        }

        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "Client id must be 9 digits long.")]
        [Key]
        public string idClientPK { get; set; }
        [Required(ErrorMessage ="Must enter the client's name.")]
        [MaxLength(20, ErrorMessage = "Client's name can't be longer than 20 characters.")]
        public string clientName { get; set; }
        [Required(ErrorMessage = "Must enter the client's last name.")]
        [MaxLength(20, ErrorMessage = "Client's last name can't be longer than 20 characters.")]
        public string clientLastName { get; set; }
        [MaxLength(20, ErrorMessage = "Client's second last name can't be longer than 20 characters.")]
        public string clientSecondLastName { get; set; }
        [MaxLength(20, ErrorMessage = "Client's company name can't be longer than 20 characters.")]
        public string company { get; set; }
        [Required(ErrorMessage ="Must enter client's telephone.")]
        [RegularExpression(@"^[0-9-]{8,20}$", ErrorMessage = "Telephone number only accepts 0-9 and '-'.")]
        [MaxLength(20, ErrorMessage = "Client's telephone can't be longer than 20 characters.")]
        public string tel { get; set; }
        [Required(ErrorMessage = "Must enter client's email.")]
        [MaxLength(30, ErrorMessage = "Client's email can't be longer than 30 characters.")]
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Project { get; set; }
    }
}
