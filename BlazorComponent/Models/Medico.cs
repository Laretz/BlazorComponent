using BlazorComponent.Repositories;
using System.ComponentModel.DataAnnotations;

namespace BlazorComponent.Models
{
    public class Medico  
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name required")]
        [MaxLength(50, ErrorMessage ="Name must be no longer than 50 digits")]
        [MinLength(3, ErrorMessage = "Name must contain at least 3 digits")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="CRM required")]
        public string? Crm { get; set; }

      
     }
    
}
 