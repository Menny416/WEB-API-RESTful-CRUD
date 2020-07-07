using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST_DEMO_CRUD.Context;
using API_REST_DEMO_CRUD.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_REST_DEMO_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuario_APIController : ControllerBase
    {
        public AppDbContext Context { get; }

        public Usuario_APIController(AppDbContext context)
        {
            this.Context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Usuario_API> Get()
        {
            return Context.Usuario_API.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Usuario_API Get(string id)
        {
            var Usuario = Context.Usuario_API.FirstOrDefault(U => U.Usuario == id);
            return Usuario;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Usuario_API Usuario_API)
        {

            try
            {
                Context.Usuario_API.Add(Usuario_API);
                Context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
           
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Usuario_API usuario)
        {

            if (usuario.Usuario == id)
            {
                Context.Entry(usuario).State = EntityState.Modified;
                Context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var usuario = Context.Usuario_API.FirstOrDefault(u => u.Usuario == id);

            if (usuario != null)
            {
                Context.Usuario_API.Remove(usuario);
                Context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
