using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneServicios")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetServicios()
        {
            var servicios = new List<Servicios>
            {
                new Servicios { Id = 1, Nombre = "Cambio de aceite", Descripcion = "Incluye mano de obra y materiales", CostoBase = 500.00m },
                new Servicios { Id = 2, Nombre = "Alineación y balanceo", Descripcion = "Servicio completo de alineación y balanceo", CostoBase = 800.00m },
                new Servicios { Id = 3, Nombre = "Revisión general", Descripcion = "Chequeo de todos los sistemas del vehículo", CostoBase = 1200.00m }
            };

            return Ok(servicios);
        }
    }
}
