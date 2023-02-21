using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoKarol.Models;

namespace ProyectoKarol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatilloXfacturasController : ControllerBase
    {
        private readonly ProyectoRestKarolContext _context;

        public PlatilloXfacturasController(ProyectoRestKarolContext context)
        {
            _context = context;
        }

        // GET: api/PlatilloXfacturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatilloXfactura>>> GetPlatilloXfacturas()
        {
            return await _context.PlatilloXfacturas.ToListAsync();
        }

        // GET: api/PlatilloXfacturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatilloXfactura>> GetPlatilloXfactura(int id)
        {
            var platilloXfactura = await _context.PlatilloXfacturas.FindAsync(id);

            if (platilloXfactura == null)
            {
                return NotFound();
            }

            return platilloXfactura;
        }

        // PUT: api/PlatilloXfacturas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlatilloXfactura(int id, PlatilloXfactura platilloXfactura)
        {
            if (id != platilloXfactura.IdPlatilloFactura)
            {
                return BadRequest();
            }

            _context.Entry(platilloXfactura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlatilloXfacturaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PlatilloXfacturas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlatilloXfactura>> PostPlatilloXfactura(PlatilloXfactura platilloXfactura)
        {
            _context.PlatilloXfacturas.Add(platilloXfactura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlatilloXfactura", new { id = platilloXfactura.IdPlatilloFactura }, platilloXfactura);
        }

        // DELETE: api/PlatilloXfacturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlatilloXfactura(int id)
        {
            var platilloXfactura = await _context.PlatilloXfacturas.FindAsync(id);
            if (platilloXfactura == null)
            {
                return NotFound();
            }

            _context.PlatilloXfacturas.Remove(platilloXfactura);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlatilloXfacturaExists(int id)
        {
            return _context.PlatilloXfacturas.Any(e => e.IdPlatilloFactura == id);
        }
    }
}
