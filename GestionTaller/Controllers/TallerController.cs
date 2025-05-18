using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneTalleres")]
    [ApiController]
    public class TallerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTalleres()
        {
            var talleres = new List<Taller>
            {
                new Taller { Id = 1, Nombre = "Taller Central", Direccion = "Av. Principal 123", Telefono = "123456789" },
                new Taller { Id = 2, Nombre = "Taller Norte", Direccion = "Calle Secundaria 456", Telefono = "987654321" },
                new Taller { Id = 3, Nombre = "Taller Sur", Direccion = "Boulevard 789", Telefono = null }
            };

            return Ok(talleres);
        }
    }
}
