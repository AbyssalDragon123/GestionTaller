using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneMecanicos")]
    [ApiController]
    public class MecanicosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMecanicos()
        {
            var mecanicos = new List<Mecanicos>
            {
                new Mecanicos { Id = 1, Nombre = "José", Apellido = "Herrera", TallerId = 1 },
                new Mecanicos { Id = 2, Nombre = "Luis", Apellido = "Pérez", TallerId = 2 },
                new Mecanicos { Id = 3, Nombre = "Ana", Apellido = "Torres", TallerId = null }
            };

            return Ok(mecanicos);
        }
    }
}
