using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{

    public class Mecanicos
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;

        [Required, StringLength(100)]
        public string Apellido { get; set; } = null!;


        // FK – taller al que pertenece
        public int? TallerId { get; set; }

        
    }
}