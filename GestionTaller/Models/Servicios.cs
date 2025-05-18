using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{

    public class Servicios
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nombre { get; set; } = null!;

        [StringLength(300)]
        public string? Descripcion { get; set; }

        public decimal CostoBase { get; set; }

        
    }
}