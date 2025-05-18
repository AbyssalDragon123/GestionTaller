using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneClientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Juan", Apellido = "Pérez", Direccion = "Calle 1", Telefono = "123456789", Correo = "juan.perez@email.com" },
                new Cliente { Id = 2, Nombre = "María", Apellido = "López", Direccion = "Calle 2", Telefono = "987654321", Correo = "maria.lopez@email.com" },
                new Cliente { Id = 3, Nombre = "Carlos", Apellido = "Sánchez", Direccion = "Calle 3", Telefono = "456123789", Correo = "carlos.sanchez@email.com" },
                new Cliente { Id = 4, Nombre = "Ana", Apellido = "Torres", Direccion = "Calle 4", Telefono = "321654987", Correo = "ana.torres@email.com" },
                new Cliente { Id = 5, Nombre = "Pedro", Apellido = "Gómez", Direccion = "Calle 5", Telefono = "654987321", Correo = "pedro.gomez@email.com" }
            };

            return Ok(clientes);
        }
    }
}