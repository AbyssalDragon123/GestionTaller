using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneTurnos")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTurnos()
        {
            var turnos = new List<Turnos>
            {
                new Turnos { Id = 1, ClienteId = 1, VehiculoId = 2, MecanicoId = 1, TallerId = 1, FechaHora = DateTime.UtcNow.AddDays(1), Estado = "Pendiente" },
                new Turnos { Id = 2, ClienteId = 2, VehiculoId = 3, MecanicoId = 2, TallerId = 2, FechaHora = DateTime.UtcNow.AddDays(2), Estado = "EnProceso" },
                new Turnos { Id = 3, ClienteId = 3, VehiculoId = 1, MecanicoId = null, TallerId = 1, FechaHora = DateTime.UtcNow.AddDays(3), Estado = "Finalizado" }
            };

            return Ok(turnos);
        }
    }
}
