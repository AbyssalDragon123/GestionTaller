using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{

    public class Taller
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nombre { get; set; } = null!;

        [Required, StringLength(250)]
        public string Direccion { get; set; } = null!;

        [StringLength(50)]
        public string? Telefono { get; set; }

        
    }
}