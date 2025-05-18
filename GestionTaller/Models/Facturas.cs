using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{

    public class Facturas
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }

       
        public DateTime FechaEmision { get; set; } = DateTime.UtcNow;

        public decimal ImporteTotal { get; set; }

    }
}