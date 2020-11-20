using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Em.ArquitecturaNCapas.Aplicacion.Interfaces;
using Em.ArquitecturaNCapas.Dominio.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Em.ArquitecturaNCapas.Servicios.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescripcionController : ControllerBase
    {
        private readonly IAdmCargueAplicacion _admCargueAplicacion;
        public DescripcionController(IAdmCargueAplicacion admCargueAplicacion)
        {
            _admCargueAplicacion = admCargueAplicacion;
        }

        [HttpGet]
        //[Route("ListaDescripcionesAsync")]
        public async Task<IActionResult> ListaDescripcionesAsync()
        {
            var respuesta = await _admCargueAplicacion.GetAdmCargueAsync();
            return Ok(respuesta);
        }
    }
}