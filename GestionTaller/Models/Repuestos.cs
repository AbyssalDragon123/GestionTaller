using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{

    public class Repuestos
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nombre { get; set; } = null!;

        [StringLength(300)]
        public string? Descripcion { get; set; }

        [Required, StringLength(50)]
        public string Codigo { get; set; } = null!;

        public int Stock { get; set; }

        public decimal PrecioUnitario { get; set; }

       
    }
}