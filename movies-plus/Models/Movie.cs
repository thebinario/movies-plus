using System.ComponentModel.DataAnnotations;

namespace webApi.Models
{
    public class Movies
    {   [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Name { get; set; }
        
        
    }
}