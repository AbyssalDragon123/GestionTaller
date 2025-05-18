using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string Direccion { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Telefono { get; set; } = string.Empty;

        [Required, StringLength(100), EmailAddress]
        public string Correo { get; set; } = string.Empty;
    }
}
