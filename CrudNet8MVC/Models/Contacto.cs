using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Nombre { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public required string Telefono { get; set; }
        [Required(ErrorMessage = "El número celular es obligatorio")]
        public required string Celular { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        public required string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
