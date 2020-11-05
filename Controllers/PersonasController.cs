using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestamoBlazor.BLL;
using PrestamoBlazor.Models;

namespace ApiPrestamo.Controllers
{
    [Route("apiPrestamos/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Personas>> Get()
        {
            return PersonasBLL.GetPersona();
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public ActionResult<List<Personas>> Get(int id)
        {
            return PersonasBLL.GetPersona();
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] Personas persona)
        {
            PersonasBLL.Guardar(persona);
        }


        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PersonasBLL.Eliminar(id);
        }
    }
}
