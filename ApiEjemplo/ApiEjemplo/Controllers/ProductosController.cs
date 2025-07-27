using ApiEjemplo.Data;
using Microsoft.AspNetCore.Mvc;
using ApiEjemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEjemplo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase

    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get: api/productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get()
        
            {
                return await _context.Productos.ToListAsync();
            }

        

        //POST: api/productos
        [HttpPost]
        public async Task<ActionResult<Producto>> Post(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = producto.Id }, producto);
        }

        //PUT: api/productos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Producto producto)
        {
            if (id != producto.Id)
                return BadRequest();

            _context.Entry(producto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
