using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneRepuestos")]
    [ApiController]
    public class RepuestosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRepuestos()
        {
            var repuestos = new List<Repuestos>
            {
                new Repuestos { Id = 1, Nombre = "Filtro de aceite", Descripcion = "Filtro para motor 1.6L", Codigo = "FO-123", Stock = 10, PrecioUnitario = 250.00m },
                new Repuestos { Id = 2, Nombre = "Bujía", Descripcion = "Bujía estándar", Codigo = "BJ-456", Stock = 25, PrecioUnitario = 120.00m },
                new Repuestos { Id = 3, Nombre = "Pastilla de freno", Descripcion = "Juego delantero", Codigo = "PF-789", Stock = 15, PrecioUnitario = 350.00m }
            };

            return Ok(repuestos);
        }
    }
}
