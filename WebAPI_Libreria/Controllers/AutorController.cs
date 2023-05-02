using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebAPI_Libreria.Contexto;
using WebAPI_Libreria.Models;

namespace WebAPI_Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AutorController(AppDbContext appDbContext)
        {
            _context = appDbContext;



        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return _context.Autores.ToList();

        }

        [HttpGet("{id}", Name = "ObtenerAutor")] 
        public ActionResult<Autor> Get(int id)
        {
            var autor = _context.Autores.FirstOrDefault(x => x.Id == id);
            if (autor == null)
            {
                NotFound();
            }
            return autor;

        }

        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
           _context.Autores.Add(autor);
            _context.SaveChanges();
            
            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.Id }, autor);

        }


    }
}
