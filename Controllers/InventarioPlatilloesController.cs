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
    public class InventarioPlatilloesController : ControllerBase
    {
        private readonly ProyectoRestKarolContext _context;

        public InventarioPlatilloesController(ProyectoRestKarolContext context)
        {
            _context = context;
        }

        // GET: api/InventarioPlatilloes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventarioPlatillo>>> GetInventarioPlatillos()
        {
            return await _context.InventarioPlatillos.ToListAsync();
        }

        // GET: api/InventarioPlatilloes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventarioPlatillo>> GetInventarioPlatillo(int id)
        {
            var inventarioPlatillo = await _context.InventarioPlatillos.FindAsync(id);

            if (inventarioPlatillo == null)
            {
                return NotFound();
            }

            return inventarioPlatillo;
        }

        // PUT: api/InventarioPlatilloes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventarioPlatillo(int id, InventarioPlatillo inventarioPlatillo)
        {
            if (id != inventarioPlatillo.IdInventarioPlatillo)
            {
                return BadRequest();
            }

            _context.Entry(inventarioPlatillo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventarioPlatilloExists(id))
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

        // POST: api/InventarioPlatilloes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InventarioPlatillo>> PostInventarioPlatillo(InventarioPlatillo inventarioPlatillo)
        {
            _context.InventarioPlatillos.Add(inventarioPlatillo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventarioPlatillo", new { id = inventarioPlatillo.IdInventarioPlatillo }, inventarioPlatillo);
        }

        // DELETE: api/InventarioPlatilloes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventarioPlatillo(int id)
        {
            var inventarioPlatillo = await _context.InventarioPlatillos.FindAsync(id);
            if (inventarioPlatillo == null)
            {
                return NotFound();
            }

            _context.InventarioPlatillos.Remove(inventarioPlatillo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventarioPlatilloExists(int id)
        {
            return _context.InventarioPlatillos.Any(e => e.IdInventarioPlatillo == id);
        }
    }
}
