using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneVehiculos")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVehiculos()
        {
            var vehiculos = new List<Vehiculos>
            {
                new Vehiculos { Id = 1, ClienteId = 1, Marca = "Toyota", Modelo = "Corolla", Anio = 2020, Patente = "ABC123", Observaciones = "Sin observaciones" },
                new Vehiculos { Id = 2, ClienteId = 2, Marca = "Ford", Modelo = "Fiesta", Anio = 2018, Patente = "XYZ789", Observaciones = "Requiere cambio de aceite" },
                new Vehiculos { Id = 3, ClienteId = 3, Marca = "Chevrolet", Modelo = "Onix", Anio = 2022, Patente = "JKL456", Observaciones = null }
            };

            return Ok(vehiculos);
        }
    }
}

