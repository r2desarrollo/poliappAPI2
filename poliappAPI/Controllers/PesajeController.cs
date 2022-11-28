using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poliappAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace poliappAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesajeController : ControllerBase
    {
        private readonly poliappDBContext context;

        public PesajeController(poliappDBContext context)
            {
            this.context = context;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Pesaje> Get()
        {
            return context.Pesaje.ToList();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public Pesaje Get(int id)
        {
            var pesaje = context.Pesaje.FirstOrDefault(p => p.Id == id);
            return pesaje;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public Pesaje Post([FromBody] int id)
        {
            var pesaje = context.Pesaje.FirstOrDefault(p => p.Id == id);
            return pesaje;
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
