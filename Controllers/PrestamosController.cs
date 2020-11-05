using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestamoBlazor.BLL;
using PrestamoBlazor.DAL;
using PrestamoBlazor.Models;

namespace ApiPrestamo.Controllers
{
    [Route("apiPrestamos/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        // GET: api/<PrestamosController>
        [HttpGet]
        public ActionResult<List<Prestamos>> Get()
        {
            return PrestamoBLL.GetPrestamos();
        }

        // GET api/<PrestamosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PrestamosController>
        [HttpPost]
        public void Post([FromBody] Prestamos prestamos)
        {
            PrestamoBLL.Guardar(prestamos);
        }



        // DELETE api/<PrestamosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PrestamoBLL.Eliminar(id);
        }
    }
}
