using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneFacturas")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFacturas()
        {
            var facturas = new List<Facturas>
            {
                new Facturas { Id = 1, ClienteId = 1, VehiculoId = 2, FechaEmision = DateTime.UtcNow.AddDays(-2), ImporteTotal = 1500.00m },
                new Facturas { Id = 2, ClienteId = 2, VehiculoId = 3, FechaEmision = DateTime.UtcNow.AddDays(-1), ImporteTotal = 2300.50m },
                new Facturas { Id = 3, ClienteId = 3, VehiculoId = 1, FechaEmision = DateTime.UtcNow, ImporteTotal = 1800.75m }
            };

            return Ok(facturas);
        }
    }
}
