using System.ComponentModel.DataAnnotations;

namespace movies_plus.Models
{
    public class Movies
    {   [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public int yaer { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Genre { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string director { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Synopsis { get; set; }

    }
}