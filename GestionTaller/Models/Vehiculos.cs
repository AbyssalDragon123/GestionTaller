using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{

    public class Vehiculos
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }

        [Required, StringLength(50)]
        public string Marca { get; set; } = null!;

        [Required, StringLength(50)]
        public string Modelo { get; set; } = null!;

        public int Anio { get; set; }

        [Required, StringLength(15)]
        public string Patente { get; set; } = null!;

        [StringLength(300)]
        public string? Observaciones { get; set; }

        
    }
}