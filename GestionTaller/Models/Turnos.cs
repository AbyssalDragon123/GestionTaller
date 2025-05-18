using System.ComponentModel.DataAnnotations;

namespace GestionTaller.Models
{

    public class Turnos
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public int? MecanicoId { get; set; }
        public int? TallerId { get; set; }

      
        public DateTime FechaHora { get; set; }

        [StringLength(50)]
        public string Estado { get; set; } = "Pendiente";   // Pendiente / EnProceso / Finalizado / Cancelado

     }
}